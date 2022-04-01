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
            new User("admin", passwordHasher.HashPassword("admin", "secret"), "admin@gmail.com"),
            new User("DogShitUser",passwordHasher.HashPassword("DogShitUser","123"),"Bob123@gmail.com"),
            
        };


        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
