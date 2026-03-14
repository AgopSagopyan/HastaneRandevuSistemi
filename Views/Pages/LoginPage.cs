using System;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Views;

namespace HastaneRandevuSistemi
{
    public partial class LoginPage : UserControl
    {
        MainRepository _mainRepository;

        private MainForm _mainForm;


        public LoginPage(MainForm mainForm)
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
            _mainForm = mainForm;
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

            User user = _mainRepository.Login(textBox1.Text, textBox2.Text);

            if (user != null)
            {
                MessageBox.Show("Login succesfull");

                AnaSayfa mainPage = new AnaSayfa(_mainForm);
                _mainForm.ShowPage(mainPage);
            }
            else
            {
                MessageBox.Show("Unsucessful Login");

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
