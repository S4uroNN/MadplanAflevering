using APIKlient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace APIKlient.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            Task<String> task = client.GetStringAsync("https://localhost:7027/api/car");
            string msg = task.Result;

            Car car = JsonSerializer.Deserialize<Car>(msg);
            return View(car);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}