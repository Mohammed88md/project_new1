using Microsoft.AspNetCore.Mvc;
using PMvc1.Models;

namespace PMvc1.Controllers
{
    
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            CarModel obj1 = new CarModel();

            obj1.Cname = "Test";
            obj1.Cprice = 100;

            return View();
            
        }
        //Get Method
       

    }
}
