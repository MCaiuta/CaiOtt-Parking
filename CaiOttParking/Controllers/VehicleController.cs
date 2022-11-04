using CaiOttParking.Models;
using CaiOttParking.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CaiOttParking.Controllers
{
    //[Route("Vehicle/Index")]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        //private readonly ICustomerRepository _customerRepository;
        //public VehicleController(IVehicleRepository vehicleRepository, ICustomerRepository customerRepository)
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            //_customerRepository = customerRepository;
        }

        //[HttpGet("{id}/{custName}")]
        public IActionResult Index(int id, string custName)
        {
            ViewData["id"] = id;
            return View(_vehicleRepository.GetAllVehicles(id));
        }

        //[HttpGet("{id}")]
        public IActionResult AssignVehicleView(int id)
        {
            var vehicle = new Vehicle();
            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        public IActionResult SubmitVehicle(Vehicle vehicle)
        {
            _vehicleRepository.CreateVehicle(vehicle);
            return RedirectToAction("Index");
        }

        public IActionResult VehicleDetailsView()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (true) RedirectToAction("Index");
            return BadRequest();
        }

    }
}
