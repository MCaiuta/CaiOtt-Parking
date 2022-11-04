using CaiOttParking.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CaiOttParking.Models
{
    [Table(name:"tblVehicle")]
    public class Vehicle
    {
        [Key]
        public string vehicleId { get; set; }
        
        public int customerId { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public string model { get; set; }

        // Not mandatory to avoid error on Selector element on AssignVehicleView
        public VehicleType? VehicleType { get; set; }


        public List<Order> orders { get; set; }

        [NotMapped]
        public int doorQuantity { get; set; }
        [NotMapped]
        public int engineCylinder { get; set; }

    }
}
