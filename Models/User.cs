using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{
    public class User
    {
        public string _userName { get; set; }
        private string _password { get; set; }
        public string _email { get; set; }

        public User(string userName, string password, string email)
        {
            _userName = userName;
            _password = password;
            _email = email;
        }

    }
}