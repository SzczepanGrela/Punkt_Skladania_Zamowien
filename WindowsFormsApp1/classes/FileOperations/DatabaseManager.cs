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
        private static DatabaseManager instance; // Statyczna instancja klasy
        private readonly string _connectionString;

        // Prywatny konstruktor, aby zapobiec tworzeniu instancji z zewnątrz
        private DatabaseManager(string connectionString=null)
        {
            _connectionString = connectionString;
        }

        // Publiczna statyczna metoda zapewniająca dostęp do instancji
        public static DatabaseManager GetInstance(string connectionString=null)
        {
            if (instance == null)
            {
                
                if (connectionString!=null) instance = new DatabaseManager(connectionString);
                else throw new Exception("No connection string provided");
            }
            return instance;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Reszta metod pozostaje bez zmian

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
            // Implementacja pozostaje do zrobienia
            return new List<Product>();
        }
    }
}
