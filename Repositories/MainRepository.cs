using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Data;
using HastaneRandevuSistemi.Models;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi.Repositories
{
    public class MainRepository
    {
        private string _connectionString = "Server=localhost;Database=deneme;Uid=root;Pwd=kerem4567";

        public List<User> GetAllUsers() {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString)) {
                conn.Open();

                string query = "SELECT id, username, password, isAdmin FROM users";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read())
                    {
                        User user = new User()
                        {
                            Id = reader.GetInt32("id"),
                            Username = reader.GetString("username"),
                            Password = reader.GetString("password"),
                        };
                        users.Add(user);
                    }
                }

            }
            return users;

        }


    }
}
