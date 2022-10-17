using Microsoft.AspNetCore.Mvc;

namespace CaiOttParking.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
