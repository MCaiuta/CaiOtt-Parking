using CaiOttParking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaiOttParking.Controllers
{
    public class VehicleController : Controller
    {
        private readonly _DbContext _dbContext;
        public VehicleController(_DbContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AssignVehicleView()
        {
            return View();
        }

        public IActionResult VehicleDetailsView()
        {
            return View();
        }

        public IActionResult SubmitVehicle()
        {
            return RedirectToAction("Index");
        }
    }
}
