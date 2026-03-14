using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Views;

namespace HastaneRandevuSistemi
{
    public partial class AnaSayfa : UserControl
    {

        private MainForm _mainForm;

        public AnaSayfa(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPage = new AdminPaneli(_mainForm);
            _mainForm.ShowPage(adminPage);
        }
    }
}
