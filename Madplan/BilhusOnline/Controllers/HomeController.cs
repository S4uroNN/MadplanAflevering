using BilhusOnline.Models;
using BusinessLogicCore.BLL;
using DTOCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

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
        public IActionResult Index(CarViewModel _model)
        {
            foreach (var modelStateEntry in ModelState.Values)
            {
                foreach (var error in modelStateEntry.Errors)
                {
                    Debug.WriteLine(error.ErrorMessage);
                }
            }

            if (ModelState.IsValid)
            {
                Car car = new Car(_model.Make, _model.Model, _model.Milage, _model.Year);

                
                _bll.AddCar(car);

                return RedirectToAction("Index");
            }
           

            return RedirectToAction("Index");
        }
    }
}

