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
using Org.BouncyCastle.Bcpg.OpenPgp;

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
            AnaSayfa2 anaSayfa2 = new AnaSayfa2(this);
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

        public void Login(string username, string password, UserControl page)
        {

            User user = _mainRepository.Login(username, password);

            AdminPaneli adminPaneli = new AdminPaneli(_mainForm, _mainRepository, this);
            

            if (user != null)
            {
                if (user.IsAdmin)
                {
                    _navigationService.Navigate(adminPaneli);

                }
                else {
                    _navigationService.Navigate(page);
                    
                }



            }
            else {
                MessageBox.Show("Başarısız");
            }

        }

        public void AdminLogin(string username, string password, UserControl page) { 
            
        }

        public void AddDoctor(string first_name, string last_name, string gender, string birth_date, string specialization, string experience_year, string email, string phone, string password)
        {

            Doctor doctor = new Doctor
            {
                FirstName = first_name,
                LastName = last_name,
                Gender = gender,
                BirthDate = birth_date,
                Specialization = specialization,
                ExperienceYear = experience_year,
                Email = email,
                Phone = phone,
                Password = password
            };
                
            _mainRepository.AddDoctor(doctor);
        }

        public void AddUser(string username, string password, bool isAdmin) {
            User user = new User { 
                Username = username,
                Password = password,
                IsAdmin = isAdmin
            };

            _mainRepository.AddUser(user);
        }

        public List<Doctor> GetDoctors() {
            return _mainRepository.GetAllDoctors();
        }

        public List<User> GetUsers() { 
            return _mainRepository.GetAllUsers(); 
        }
    }
}
