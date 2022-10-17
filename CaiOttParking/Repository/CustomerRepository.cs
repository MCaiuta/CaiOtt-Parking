using CaiOttParking.Models;
using System.Runtime.CompilerServices;

namespace CaiOttParking.Repository
{
    public interface ICustomerRepository
    {
        public bool createCustomer(Customer customer);
        public List<Customer> GetAll();

        public Customer GetCustomerById(int id);

        public bool Update(Customer customer);

        public bool deleteCustomer(int customerId);
    }
    public class CustomerRepository: ICustomerRepository
    {
        private readonly _DbContext _db;
        
        public CustomerRepository(_DbContext db)
        {
            _db = db;
        }

        public bool createCustomer(Customer customer)
        {
            var customer_db = new Customer();
            try
            {
                customer_db.name = customer.name;
                customer_db.creationDate = DateTime.Now;
                customer_db.birthDate = customer.birthDate;
                _db.customer.Add(customer_db);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public List<Customer> GetAll()
        {
            return _db.customer.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _db.customer.Find(customerId);
        }

        public bool Update(Customer customer)
        {
            if (customer != null && customer.customerId > 0)
            {
                Customer _cust = _db.customer.Find(customer.customerId);
                if (_cust != null)
                {
                    _cust.name = customer.name;
                    _cust.creationDate = DateTime.Now;
                    _cust.birthDate = customer.birthDate;
                    _db.customer.Update(_cust);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool deleteCustomer(int customerId)
        {
            if (customerId > 0)
            {
                var customer = _db.customer.Find(customerId);
                if (customer != null)
                {
                    _db.customer.Remove(customer);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
