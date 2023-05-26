using BusinessLogicCore.BLL;
using DTOCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        CarBLL _bll = new CarBLL();


        [HttpGet]
        public Car GetCar()
        {
            return (_bll.GetCarList().First());
        }
       
    }
}
