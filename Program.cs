using System.Drawing.Text;
using HastaneRandevuSistemi.Controllers;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Services;
using HastaneRandevuSistemi.Views.Pages;

namespace HastaneRandevuSistemi.Views
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}