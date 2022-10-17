using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaiOttParking.Models
{
    [Table(name:"tblCustomer")]
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        [Required]
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime birthDate { get; set; }

        public List<Vehicle> vehicles { get; set; }
        public List<Order> orders { get; set; }

    }
}
