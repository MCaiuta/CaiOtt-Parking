using System.ComponentModel.DataAnnotations.Schema;

namespace CaiOttParking.Models
{
    [Table(name:"tblMotorCycle")]
    public class Motorcycle: Vehicle
    {
        public int engineCylinder { get; set; }
    }
}
