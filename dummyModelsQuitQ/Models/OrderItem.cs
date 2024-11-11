using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Navigation properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
