using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi.Data
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection()
        {
            _connectionString = "Server=localhost;Database=deneme;Uid=root;Pwd=kerem4567;";
        }

        public MySqlConnection GetConnnection()
        {
            var conn = new MySqlConnection(_connectionString);

            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex) 
            {
                throw new Exception("Could not connect to database");
            }
        }
    }
}
