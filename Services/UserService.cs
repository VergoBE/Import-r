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
        public List<User> users;
        public DbGenericService<User> DbService;
        public IEnumerable<User> GetUsers()
        {
            return users;
        }
        public UserService(DbGenericService<User> dbService)
        {
            users = MockData.MockUsers.GetMockUsers();
            DbService = dbService;
            //users = dbService.GetObjectsAsync().Result.ToList();
            dbService.SaveUsers(users);
            
        }
    }
}
