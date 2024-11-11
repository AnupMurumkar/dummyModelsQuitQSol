using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public DateTime OrderDate { get; set; }

        [MaxLength(255)]
        public string ShippingAddress { get; set; }

        public decimal TotalAmount { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}
