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
using HastaneRandevuSistemi.Repositories;

namespace HastaneRandevuSistemi.Views.Pages.AdminTabs
{
    public partial class AdminPanelDoctorsTab : UserControl
    {
        private readonly MainRepository _mainRepository;

        private readonly Controller _controller;

        public AdminPanelDoctorsTab(MainRepository mainRepository, Controller controller)
        {
            InitializeComponent();
            _mainRepository = mainRepository;
            _controller = controller;
        }



        private void AdminPanelDoctorsTab_Load(object sender, EventArgs e)
        {
            dataGridDoktorlar.DataSource = _controller.GetDoctors();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            _controller.AddDoctor(
                txtDoktorAd.Text,
                textBox1.Text,
                comboCinsiyet.Text,
                dateTimePicker1.Text,
                comboBrans.Text,
                "",
                "",
                "",
                ""
            );

        }
    }
}
