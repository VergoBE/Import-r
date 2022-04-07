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
            new User("admin", passwordHasher.HashPassword(null, "123"),"admin@gmail.com"),
            new User("DogShitUser",passwordHasher.HashPassword(null,"321"),"bob1@gmail.com"),
            
        };


        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
