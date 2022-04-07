using Importør.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Services
{
    public class DbGenericService<T> : IService<T> where T :class
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new CarDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }
        public async Task AddObjectAsync(T obj)
        {
            using (var context = new CarDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new CarDbContext())
            {
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new CarDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }
        }
        //TODO Fix userAdd så jeg har en db uden hasherfejl
        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new CarDbContext())
            {
                return await context.Set<T>().FindAsync(id);
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
