using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Models;
using Microsoft.AspNetCore.Identity;

namespace Importør.MockData
{
    public class MockUsers
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>() {
            new User("VergoBE", passwordHasher.HashPassword(null, "secre"), "fighters@live.dk"),
            
        };


        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
