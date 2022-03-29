using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{
    public class User
    {
        public string UserName { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }

        public User(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }

    }
}
