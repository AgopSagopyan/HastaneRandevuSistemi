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

namespace HastaneRandevuSistemi.Views.Pages.AdminTabs
{
    public partial class AdminPanelUsersTab : UserControl
    {
        private readonly MainRepository _mainRepository;

        public AdminPanelUsersTab(MainRepository mainRepository)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor {
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
    }
}
