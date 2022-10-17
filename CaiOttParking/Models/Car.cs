using System.ComponentModel.DataAnnotations.Schema;

namespace CaiOttParking.Models
{
    [Table(name:"tblCar")]
    public class Car: Vehicle
    {
        public int doorQuantity { get; set; }
    }
}
