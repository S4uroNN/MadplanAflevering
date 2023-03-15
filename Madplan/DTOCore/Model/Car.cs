﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DTOCore.Model
{
    
    public class Car
    {
       
        public Car(int id, string make, string model, int milage, int owners)
        {
            ID = id;
            Make = make;
            Model = model;
            Milage = milage;
            Owners = owners;

        }
        public Car(string make, string model, int milage)
        {
            Make = make;
            Model = model;
            Milage = milage;

        }
        [Key]
        public int ID { get;set; }
        public String Make { get; set; }
        public string Model { get; set; }
        public int Milage { get; set; }
        public int Owners { get; set; }
        public override string ToString()
        {
            return "Make: " + Make + " " +Model + " Milage: " + Milage + " Owners " + Owners;
        }

    }
}