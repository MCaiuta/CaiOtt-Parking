using Microsoft.AspNetCore.Mvc;

namespace CaiOttParking.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
