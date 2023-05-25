using BilhusOnline.Models;
using BusinessLogicCore.BLL;
using DTOCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BilhusOnline.Controllers
{
    public class HomeController : Controller
    {
        private CarBLL _bll = new CarBLL();
        private List<Car> cars;
        private CarViewModel _viewModel = new CarViewModel();

        [HttpGet]
        public IActionResult Index()
        {

            cars = _bll.GetCarList();
            _viewModel.Itemlist = cars;
            return View(_viewModel);
        }
        [HttpPost]
        public IActionResult Index(CarViewModel model)
        {
            if (ModelState.IsValid)
            {
                CarViewModel carViewModel = new CarViewModel()
                {
                    Make = model.Make,
                    Model = model.Model,
                    Milage = model.Milage,
                    Year = model.Year

                };

                Car car = new Car(model.Make, model.Model, model.Milage, model.Year);

                
                _bll.AddCar(car);

                return View();
            }
           

            return View();
        }
    }
}

