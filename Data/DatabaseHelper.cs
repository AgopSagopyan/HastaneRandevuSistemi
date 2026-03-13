using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi.Data
{
    public class DatabaseHelper
    {
        private readonly DatabaseConnection _connection;

        public DatabaseHelper()
        {
            _connection = new DatabaseConnection();
        }

        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            using (var conn = _connection.GetConnnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

    }
}
