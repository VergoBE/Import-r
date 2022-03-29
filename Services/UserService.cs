using Importør.Interface;
using Importør.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Services
{
    public class UserService : IUserService
    {
        private List<User> users;
        public IEnumerable<User> GetUsers()
        {
            return users;
        }
    }
}
