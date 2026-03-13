using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Data;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseConnection _connection;

        public UserRepository() { 
            _connection = new DatabaseConnection();
        }

        public bool ValidateUser(string username, string password) {
            using (var conn = _connection.GetConnnection())
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE username=@u AND password=@p", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var result = (long)cmd.ExecuteScalar();
                return result > 0;
            }
            
        }
    }
}
