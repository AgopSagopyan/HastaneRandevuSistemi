using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Repositories;
using HastaneRandevuSistemi.Services;
using HastaneRandevuSistemi.Views;
using HastaneRandevuSistemi.Views.Pages;

namespace HastaneRandevuSistemi.Controllers
{
    public class Controller
    {
        private readonly NavigationService _navigationService;

        private readonly MainForm _mainForm;

        private readonly MainRepository _mainRepository;


        public Controller(NavigationService navigationService, MainForm mainForm, MainRepository mainRepository) {
            _navigationService = navigationService;
            _mainForm = mainForm;
            _mainRepository = mainRepository;
        }

        public void GoToAdminPage() {
            AdminPaneli adminPanel = new AdminPaneli(null, null, this);
            _navigationService.Navigate(adminPanel);
            
        }

        public void GoToMainPage() { 
            AnaSayfa2 anaSayfa2 = new AnaSayfa2();
            _navigationService.Navigate(anaSayfa2);
        }

        public void GoToLoginPage()
        {
            LoginPage loginPage = new LoginPage(_mainForm, this);
            _navigationService.Navigate(loginPage);
        }

        public void GoToPage(UserControl page) {
            _navigationService.Navigate(page);
        }

        public void Login(string username, string password)
        {

            User user = _mainRepository.Login(username, password);

            if (user != null) {
                MessageBox.Show("Nigga");
            }

        }
    }
}
