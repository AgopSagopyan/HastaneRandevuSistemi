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
using HastaneRandevuSistemi.Views.Pages.AdminPanelTabs;

namespace HastaneRandevuSistemi.Views.Pages
{
    public partial class AnaSayfa2 : UserControl
    {
        private readonly Controller _controller;
        private bool _isAdmin;

        public AnaSayfa2(Controller controller, bool isAdmin)
        {
            InitializeComponent();
            _controller = controller;
            _isAdmin = isAdmin;

        }

        private void AnaSayfa2_Load(object sender, EventArgs e)
        {
            if (_isAdmin) {
                button9.Visible = true;
            } else
            {
                button9.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.GoToLoginPage();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            _controller.GoToAdminPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorProfil doktorProfil = new DoktorProfil(_controller);

            _controller.GoToPage(doktorProfil);
        }
    }
}
