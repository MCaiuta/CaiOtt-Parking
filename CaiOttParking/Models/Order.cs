using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaiOttParking.Models
{
    public enum orderStatus :int {
        TobePaid=0,
        PayedByCreditCard =1,
        PayedByCash=2
	}

    [Table(name:"tblOrder")]
    public class Order
    {
        [Key]
		public int orderId { get; set; }

        public int customerId { get; set; }
        public string vehicleId { get; set; }

        public DateTime hourStart { get; set; }
		public DateTime hourEnd { get; set; }
		public bool sameDay { get; set; }
		public orderStatus status { get; set; }



    }
}
