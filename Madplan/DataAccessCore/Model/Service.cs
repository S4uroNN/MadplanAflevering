using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Model
{
    internal class Service
    {
        [Key]
        public int ID { get; set; }
        public string Address { get; set; }
        public List<Car>? cars { get; set; }
        public Service(string address)
        {
            Address = address;
        }

        public Service(int id, string address)
        {
            ID = id;
            Address = address ;
        }


        public void Addcar(Car car)
        {
            if (!cars.Contains(car))
            {
                cars.Add(car);
            }
        }

        public void Removecar(Car car)
        {
            if (cars.Contains(car))
            {
                cars.Remove(car);
            }
        }

        public List<Car> Getcars()
        {
            return new List<Car>(cars);
        }
    }
}
