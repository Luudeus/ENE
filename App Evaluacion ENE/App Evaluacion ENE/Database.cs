using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App_Evaluacion_ENE
{
    public class Database : IDisposable
    {
        private readonly MySqlConnection _connection;

        public Database()
        {
            string server = "localhost";
            string database = "ENE";
            string username = "root";
            string password = "pfxj7KtKxrjf";
            string port = "3306";

            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};Port={port};";
            _connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
