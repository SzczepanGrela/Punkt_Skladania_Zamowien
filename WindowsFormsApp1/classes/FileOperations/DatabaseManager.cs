using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.DataObjects;

namespace WindowsFormsApp1.classes.FileOperations
{
    internal class DatabaseManager
    {

        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
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

        public int CountMatchingRecords(string query)
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




        public void ExecuteCommand(string commandText)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }




        public List<Product> FilterProducts(string criteria)
        {

            return new List<Product>();

            // Zaimplementuj logikę filtrowania produktów, np. przez zapytanie SQL z odpowiednimi warunkami
        }


    }
}
