using DataAccessCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Context
{
    internal class CarContext : DbContext
    {
        
        public CarContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database Created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LIOGET1\\SQLEXPRESS;Initial Catalog=Bilhus;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car[] {
                new Car{ID=1,Make="Hyundai",Model="i30", Milage=555, Owners=1},
                new Car{ID=2,Make="Ford",Model="Kuga", Milage=11000, Owners=2},
                new Car{ID=3,Make="Hyundai",Model="i20", Milage=5, Owners=0}
            });
        }


        public DbSet<Car> Cars { get; set; }

    }
}
