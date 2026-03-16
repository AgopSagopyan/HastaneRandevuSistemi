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

namespace HastaneRandevuSistemi.Views.Pages.AdminTabs
{
    public partial class AdminPanelUsersTab : UserControl
    {
        private readonly MainRepository _mainRepository;

        private readonly Controller _controller;

        public AdminPanelUsersTab(MainRepository mainRepository, Controller controller)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _controller = controller;
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                FirstName = "Nigga",
                LastName = "Zenci",
                Gender = "Erkek",
                BirthDate = "Dün",
                Specialization = "Negroid",
                ExperienceYear = "asdad",
                Email = "asdasd",
                Phone = "asd",
                Password = "asdasd"
            };

            _mainRepository.AddDoctor(doctor);
        }

        private void AdminPanelUsersTab_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _controller.GetUsers();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            _controller.AddUser(txtDoktor.Text, textBox1.Text, checkBox1.Checked);
        }
    }
}
