using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Repositories;

namespace HastaneRandevuSistemi.Controllers
{
    public class LoginController
    {
        private readonly UserRepository _userRepo;
        public LoginController() {
            _userRepo = new UserRepository();
        }

        public bool Login(string username, string password) {
            return _userRepo.ValidateUser(username, password);
        }
    }
}
