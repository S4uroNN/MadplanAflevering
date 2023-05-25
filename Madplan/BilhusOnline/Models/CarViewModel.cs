using BusinessLogicCore.BLL;
using DTOCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BilhusOnline.Models
{

    public class CarViewModel
    {
        public List<Car> Itemlist { get; set; }

        [Required(ErrorMessage = "Please enter the make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter the mileage")]
        [Range(0, int.MaxValue, ErrorMessage = "The mileage must be a positive number")]
        public int Milage { get; set; }

        [Required(ErrorMessage = "Please enter the year")]
        [Range(1900, 3000, ErrorMessage = "Invalid year")]
        public int Year { get; set; }
    }
}

