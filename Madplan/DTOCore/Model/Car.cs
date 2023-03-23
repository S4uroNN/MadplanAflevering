using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DTOCore.Model
{

    public class Car : INotifyCollectionChanged
    {

        public Car(int id, string make, string model)
        {
            ID = id;
        }
        public Car(int id, string make, string model, int? milage, int? owners)
        {
            ID = id;
            Make = make;
            Model = model;
            Milage = milage;
            Owners = owners;

        }
        public Car(string make, string model, int? milage)
        {
            Make = make;
            Model = model;
            Milage = milage;

        }
        public Car(string make, string model, int? milage, int? owners)
        {
            Make = make;
            Model = model;
            Milage = milage;
            Owners = owners;

        }
        [Key]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Milage { get; set; }
        public int? Owners { get; set; }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public override string ToString()
        {
            return Make + " " + Model + " | Milage:  " + Milage;
        }

    }
}