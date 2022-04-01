using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Models
{
    public class User
    {
        [Key, Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
       

        public User(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
            
        }

    }
}
