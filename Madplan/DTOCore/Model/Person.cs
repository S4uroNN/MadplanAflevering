using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOCore.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public List<Car>? OwnedCars { get; set; }

        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public Person(int id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void AddCar(Car car)
        {
            if (!OwnedCars.Contains(car))
            {
                OwnedCars.Add(car);
            }
        }
        public void RemoveCar(Car car)
        {
            if (OwnedCars.Contains(car))
            {
                OwnedCars.Remove(car);
            }
        }

        public override string ToString()
        {
            return Name + " " + Age + "Years";
        }
    }
}
