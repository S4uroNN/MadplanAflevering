using BusinessLogicCore.BLL;
using Microsoft.AspNetCore.Mvc;

namespace BilhusOnline.Controllers
{
    public class HomeController : Controller
    {
        private CarBLL _bll = new CarBLL();

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection iformCollection)
        {
            string Navn = ((string)iformCollection["make"]);

            ViewBag.Navn = _bll.GetCar(Navn);
            return View();
        }
    }
}
