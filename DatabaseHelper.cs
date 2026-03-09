using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi
{
    public class DatabaseHelper
    {
        private static string connString = "Server=localhost;Database=deneme;Uid=root;Pwd=kerem4567";

        public static MySqlConnection GetConnecion() {
            return new MySqlConnection(connString);
        }

        public static bool TestConnection() {
            using (var conn = GetConnecion()) {
                try {
                    conn.Open();
                    return true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public static int ExecuteQuery(string sql, MySqlParameter[] parameters = null) {

            using (MySqlConnection conn = GetConnecion()) {
                try { 
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open ();
                    return cmd.ExecuteNonQuery();

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    return -1;
                }
            }
        }

        public static DataTable GetDataTable(string sql, MySqlParameter[] parameters = null) {

            using (MySqlConnection conn = GetConnecion()) {
                try {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static bool AuthenticateUser(string username, string password) {

            string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            MySqlParameter[] parameters = {
                new MySqlParameter("username", username),
                new MySqlParameter("password", password)
            };

            using (MySqlConnection conn = GetConnecion()) {
                try {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        }
    }
}
