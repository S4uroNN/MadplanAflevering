using DataAccessCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-U2JGUM3J\\SQLEXPRESS;Initial Catalog=Bilhus;Integrated Security=SSPI; TrustServerCertificate=true");

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LIOGET1\\SQLEXPRESS;Initial Catalog=Bilhus1;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car[] {
                new Car{ID=1,Make="Hyundai",Model="i30",Year= 2016, Milage=250000, MOT= new DateTime(2023,04,01)},
                new Car{ID=2,Make="Ford",Model="Kuga",Year= 2016, Milage=114000, MOT= new DateTime(2020,04,10)},
                new Car{ID=3,Make="Hyundai",Model="i20",Year= 2023, Milage=5},
            });


            modelBuilder.Entity<Service>().HasData(new Service[]
            {
                new Service{ID=1, Address="Sønderhøj 30"}
            });

            modelBuilder.Entity<Person>().HasData(new Person[]
            {
                new Person{Id=1, Name="Jens Jensen", Age="39"},
                new Person{Id=2, Name="Lasse", Age="24"},
                new Person{Id=3, Name="Morten", Age="18"},
                new Person{Id=4, Name="Mathias", Age="18"}

            });
        }

        public DbSet<Car> Cars { get; set;}
        public DbSet<Service> Services { get;set;} 
        public DbSet<Person> Owners { get; set;}

    }
}
