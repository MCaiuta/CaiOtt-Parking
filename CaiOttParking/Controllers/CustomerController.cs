using CaiOttParking.Models;
using CaiOttParking.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CaiOttParking.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            var customers = _customerRepository.GetAll();
            return View(customers);
        }

        public IActionResult CreateCustView()
        {
            return View();
        }

        public IActionResult UpdateCustView(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        public IActionResult UpdateCustomer(Customer customer)
        {
            if (_customerRepository.Update(customer))
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int customerID)
        {
            _customerRepository.deleteCustomer(customerID);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult SubmitCustomer(Customer customer)
        {
            _customerRepository.createCustomer(customer);
            return RedirectToAction("Index");
        }
    }
}
