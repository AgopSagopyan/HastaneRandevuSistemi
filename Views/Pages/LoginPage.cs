using System;
using HastaneRandevuSistemi.Controllers;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Views;
using HastaneRandevuSistemi.Views.Pages;
using System.Net.Mail;

namespace HastaneRandevuSistemi
{
    public partial class LoginPage : UserControl
    {
        MainRepository _mainRepository;

        private MainForm _mainForm;

        private readonly Controller _controller;


        public LoginPage(MainForm mainForm, Controller controller)
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
            _mainForm = mainForm;

            _controller = controller;
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_controller.GoToMainPage();

            AnaSayfa2 anaSayfa = new AnaSayfa2(_controller, false);

            _controller.Login(textBox1.Text, textBox2.Text, anaSayfa);

            //ENABLE LATER
            //_controller.Login("kerem", "123");


            /*List<User> users = _mainRepository.GetAllUsers();

            dataGridView1.DataSource = users;

            User user = _mainRepository.Login(textBox1.Text, textBox2.Text);

            if (user != null)
            {
                MessageBox.Show("Login succesfull");

                AnaSayfa mainPage = new AnaSayfa(_mainForm);
// _mainForm.ShowPage(mainPage);
            }
            else
            {
                MessageBox.Show("Unsucessful Login");

            }
            */


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _controller.GoToSignUpPage();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _controller.GoToSignUpPage();
        }
    }
}

