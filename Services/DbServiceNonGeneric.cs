using Importør.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Services
{
    public class DbServiceNonGeneric
    {
        public async Task SaveItems(List<Car> Cars)
        {
            using (var context = new CarDbContext())
            {
                foreach (Car car in Cars)
                {
                    context.Cars.Add(car);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }


        public async Task SaveUsers(List<User> users)
        {
            using (var context = new CarDbContext())
            {
                foreach (User user in users)
                {
                    context.Users.Add(user);

                }
                context.SaveChanges();
            }
        }
    }
}
