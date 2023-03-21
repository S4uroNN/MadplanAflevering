using System.ComponentModel.DataAnnotations;

namespace DataAccessCore.Model
{
    internal class Car
    {
        [Key]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Milage { get; set; }
        public int? Owners { get; set; }

        public Car() { }
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


    }
}