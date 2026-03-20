using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Services;

namespace HastaneRandevuSistemi.Views.Pages
{
    public partial class SignUp : UserControl
    {

        private readonly MainRepository _mainRepository;
        private readonly MainServices _mainServices;

        public SignUp(MainRepository mainRepository, MainServices mainServices)
        {
            InitializeComponent();

            _mainRepository = mainRepository;
            _mainServices = mainServices;
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            User kullanici = new User
            {
                Username = username_textBox.Text,
                Email = email_textBox.Text,
                Password = password_textBox.Text,
            };

            _mainRepository.AddUser(kullanici);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainServices.SendEmail(email_textBox.Text); 
        }
    }
}
