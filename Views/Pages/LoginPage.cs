using System;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;

namespace HastaneRandevuSistemi
{
    public partial class LoginPage : UserControl
    {
        MainRepository _mainRepository;

        public LoginPage()
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> users = _mainRepository.GetAllUsers();

            dataGridView1.DataSource = users;


        }
    }
}
