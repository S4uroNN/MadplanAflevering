﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOCore.Model
{
    public class Service
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Car>? cars { get; set; }
        public Service(string adress)
        {
            adress = Address;
        }
        public Service(int ID, string adress) 
        {
            Id = ID;
            Address = adress;
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
