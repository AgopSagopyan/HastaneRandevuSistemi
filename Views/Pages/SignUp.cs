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
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Services;

namespace HastaneRandevuSistemi.Views.Pages
{
    public partial class SignUp : UserControl
    {

        private readonly MainRepository _mainRepository;
        private readonly MainServices _mainServices;
        private readonly Controller _controller;

        string confirmationCode;

        public SignUp(MainRepository mainRepository, MainServices mainServices, Controller controller)
        {
            InitializeComponent();

            _mainRepository = mainRepository;
            _mainServices = mainServices;
            _controller = controller;
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            confirmationCode = _mainServices.SendEmail(email_textBox.Text);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (code_textBox.Text == confirmationCode)
            {

                User kullanici = new User
                {
                    Username = username_textBox.Text,
                    Email = email_textBox.Text,
                    Password = password_textBox.Text,
                };

                _mainRepository.AddUser(kullanici);
            }
            else
            {
                MessageBox.Show("Girilen kod hatali");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _controller.GoToLoginPage();
        }
    }
}
