using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.DataObjects;

namespace WindowsFormsApp1.classes.FileOperations
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;   // singlton instance
        private readonly string _connectionString;


        private DatabaseManager(string connectionString = null)
        {
            _connectionString = connectionString;
        }


        public static DatabaseManager GetInstance(string connectionString = null)
        {
            if (instance == null)
            {

                if (connectionString != null) instance = new DatabaseManager(connectionString);
                else throw new Exception("No connection string provided");
            }
            return instance;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }



        public List<T> ExecuteQuery<T>(string query, Func<SqlDataReader, T> mapFunction)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var results = new List<T>();
                        while (reader.Read())
                        {
                            results.Add(mapFunction(reader));
                        }
                        return results;
                    }
                }
            }
        }

        public int CountRecords(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void ExecuteCommand(bool isUpdate, string TableName, string[] columnNames, string[] values,string condition)
        {
            string commandText;

            if (!isUpdate)
            {
                 commandText = CreateInsertCommand(TableName, columnNames, values);
            }
            else
            {
                 commandText = CreateUpdateCommand(TableName, columnNames, values,condition);
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        public List<int> ExecuteCommandGetID(string TableName, string wantedColumn, string[] columnNames, string[] values)
        {


            string commandText = CreateInsertOutputCommand(TableName, wantedColumn, columnNames, values);


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var results = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            results.Add(id);
                        }
                        return results;
                    }
                }
            }
        }




        private string CreateInsertCommand(string TableName, string[] columnNames, string[] values)
        {
            
            string columnsPart = string.Join(",", columnNames);

            string valuesPart = string.Join(",", values);
           
            return $"INSRT INTO {TableName} ({columnsPart}) VALUES ({valuesPart})";
        }



        private string CreateUpdateCommand(string TableName, string[] columnNames, string[] values, string condition)
        {
           
            string valuesPart = "";
            for (int i = 0; i < values.Length; i++)
            {
                valuesPart += columnNames[i] + "=" + values[i];
                if (i != values.Length - 1) valuesPart += ",";
            }
           
            return $" UPDATE {TableName} SET  {valuesPart} WHERE {condition}";
        }




        private string CreateInsertOutputCommand(string TableName, string wantedColumn, string[] columnNames, string[] values)
        {
         
            string columnsPart = string.Join(",", columnNames);

            string valuesPart = string.Join(",", values);

            return $"INSRT INTO {TableName} ({columnsPart}) OUTPUT INSERTED.{wantedColumn} VALUES ({valuesPart})";



        }



        public void InsertObject<T>(T obj, string tableName, Func<T, SqlParameter[]> mapFunction)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlParameter[] parameters = mapFunction(obj);
                string [] columnNames = parameters.Select(p => p.ParameterName.Substring(1)).ToArray(); // getting column name by removing @ from parameter name
                string [] valuesPlaceholders = parameters.Select(p => p.ParameterName).ToArray(); 

                var commandText = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", valuesPlaceholders)})";

                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int InsertObjectGetID<T>(T obj, string tableName, Func<T, SqlParameter[]> mapFunction)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlParameter[] parameters = mapFunction(obj);
                string[] columnNames = parameters.Select(p => p.ParameterName.Substring(1)).ToArray(); // getting column name by removing @ from parameter name
                string[] valuesPlaceholders = parameters.Select(p => p.ParameterName).ToArray();

                
                var commandText = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) OUTPUT INSERTED.ID VALUES ({string.Join(", ", valuesPlaceholders)})";

                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(parameters);
                    
                    var insertedID = command.ExecuteScalar();
                    return Convert.ToInt32(insertedID); 
                }
            }
        }







        public void DeleteObject(string tableName, string columnName, object ConditionValue)
        {
            string strConditionValue;
            if (ConditionValue.GetType() == typeof(string))    
            {
                strConditionValue = $"'{ConditionValue}'";
            }
            else strConditionValue = ConditionValue.ToString();

            strConditionValue = strConditionValue.Replace(",", ".");  // gettting rid off polish coma


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                
                string commandText = $"DELETE FROM {tableName} WHERE {columnName} = @ConditionValue";

                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                   
                    command.Parameters.AddWithValue("@ConditionValue", ConditionValue);

                    command.ExecuteNonQuery();
                }
            }
        }








    }
}
