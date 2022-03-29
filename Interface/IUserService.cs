using Importør.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Interface
{
    interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}
