using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Model
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public List<Car>? OwnedCars { get; set; }

        public Person(string name, string age, List<Car>? ownedCars)
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
    }
}
