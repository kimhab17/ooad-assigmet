using System;
using System.Data.SqlClient;

namespace saleAndBillingSystem
{
    // 1. Singleton Pattern: Ensures only a single instance of DatabaseManager exists.
    // It provides a global point of access to the connection string.
    public sealed class DatabaseManager
    {
        private static DatabaseManager _instance = null;
        private static readonly object _padlock = new object();

        private readonly string _connectionString;

        private DatabaseManager()
        {
            // Initialize connection string here
            _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SalesBillingDB;Integrated Security=True";
        }

        public static DatabaseManager Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseManager();
                    }
                    return _instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
