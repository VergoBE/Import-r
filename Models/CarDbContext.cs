using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Importør.Models
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbSet<User> users, DbSet<Car> cars, DbSet<Order> orders)
        {
            Users = users;
            Cars = cars;
            Orders = orders;
        }
        public CarDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    
}
}
