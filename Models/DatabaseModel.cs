using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi.Models
{
    public class DatabaseModel
    {
        private string connectionString = "Server=";

        public string CheckConnection() {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    return "Bağlantı Başarılı";
                }
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }
    }
}
