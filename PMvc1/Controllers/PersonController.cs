using Microsoft.AspNetCore.Mvc;

namespace PMvc1.Controllers
{
    public class PersonController : Controller
    {
        List<String> items = new List<String>();
        public IActionResult Index()
        {
            return View();
        }

        //Get
        public IActionResult Create()
        {

            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(string Pname, int Page)
        {
            if(Pname != null && Page != 0)
            {
                items.Add(Pname);
                ViewBag.Message = "well done!";
                ViewBag.Status = "Success";
            }
            else
            {
                ViewBag.Message = "Invalid";
                ViewBag.Status = "Fail"; 
                //that is Right>>>>
            }

            return View();
        }

    }
}
