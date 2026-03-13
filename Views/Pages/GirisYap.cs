using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuSistemi.Controllers;
using HastaneRandevuSistemi.Data;
using MySql.Data.MySqlClient;

namespace HastaneRandevuSistemi
{
    public partial class GirisYap : UserControl
    {
        private readonly LoginController _loginController;

        public GirisYap()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (_loginController.Login(username, password)) {
                MessageBox.Show("Login Successful!");
            }


        }
    }
}
