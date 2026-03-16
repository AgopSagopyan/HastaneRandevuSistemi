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

namespace HastaneRandevuSistemi.Views.Pages.AdminPanelTabs
{
    public partial class DoktorProfil : UserControl
    {

        private readonly Controller _controller;

        public DoktorProfil(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            _controller.GoToMainPage();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
