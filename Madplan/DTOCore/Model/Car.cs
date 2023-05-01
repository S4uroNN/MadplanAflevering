using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DTOCore.Model
{

    public class Car

    {
        [Key]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Milage { get; set; }
        //public List<Person>? Owners { get; set; }

        public int Year { get; set; }
        public DateTime? Synet { get; set; }
        //public Service Service { get; set; }


        public Car(int id, string make, string model, int? milage, int year, DateTime? synet)
        {
            ID = id;
            Make = make;
            Model = model;
            Milage = milage;
            Year = year;
            Synet = synet;
        }
        public Car(string make, string model, int? milage, int year, DateTime? synet)
        {
            Make = make;
            Model = model;
            Milage = milage;
            Year = year;
            Synet = synet;
        }

        //public void SetService(Service service)
        //{
        //    if (Service != service)
        //    {
        //        Service = service;
        //    }
        //}

        //public void RemoveService(Service service)
        //{
        //    if (Service != null)
        //    {
        //        Service = null;
        //    }
        //}

        //public void addPerson(Person person)
        //{
        //    if (!Owners.Contains(person))
        //    {
        //        Owners.Add(person);
        //    }
        //}

        //public void removePerson(Person person)
        //{
        //    if (Owners.Contains(person))
        //    {
        //        Owners.Remove(person);
        //    }
        //}



        public override string ToString()
        {
            return Make + " " + Model + " Year: " + Year + " | Milage:  " + Milage;
        }

    }
}