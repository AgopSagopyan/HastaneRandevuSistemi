using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi
{
    public partial class GirisYap : UserControl
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (DatabaseHelper.AuthenticateUser(user, pass)) { 
                
            }


            string sql = "select * from users";

            DataTable data = DatabaseHelper.GetDataTable(sql);

            if (data != null)
            {
                dataGridView1.DataSource = data;

                
            }
            else {
                MessageBox.Show("Could Not Load Data");
            }

            /*
            sql = "INSERT INTO users (username, password) VALUES (@username, @password)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@username", "kerem"),
                new MySqlParameter("@password", "123")
            };

            int result = DatabaseHelper.ExecuteQuery(sql, parameters);

            if (result > 0) {
                MessageBox.Show("Data inserted succesfully!");
            }
            else
            {
                MessageBox.Show("Insert failed");
            }
            */

        }
    }
}
