using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models; 

namespace MedConnect.ViewModels
{
    public class LoginViewModel
    {
        private User user; 

        public LoginViewModel()
        {
            user = new User(); 
        }

        public bool validateLogin(string username, string password)
        {
            return true; 
        }

        public User getUser(string username)
        {
            return user; 
        }

    }
}
