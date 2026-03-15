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
using HastaneRandevuSistemi.Views;
using HastaneRandevuSistemi.Views.Pages;
using HastaneRandevuSistemi.Views.Pages.AdminTabs;

namespace HastaneRandevuSistemi
{
    public partial class AdminPaneli : UserControl
    {
        private MainForm _mainForm;

        private MainRepository _mainRepository;

        private Controller _controller;

        public AdminPaneli(MainForm mainForm, MainRepository mainRepository, Controller controller)
        {
            InitializeComponent();
            _controller = controller;
            _mainForm = mainForm;
            _mainRepository = mainRepository;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanelDoctorsTab adminPanelDoctorsTab = new AdminPanelDoctorsTab(_mainRepository);

            panel3.Controls.Clear();
            panel3.Controls.Add(adminPanelDoctorsTab);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanelUsersTab adminUsersTab = new AdminPanelUsersTab(_mainRepository);

            panel3.Controls.Clear();
            panel3.Controls.Add(adminUsersTab);
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // _controller.GoToMainPage();

            AnaSayfa2 anaSayfa = new AnaSayfa2();

            _controller.GoToPage(anaSayfa);
        }
    }
}
