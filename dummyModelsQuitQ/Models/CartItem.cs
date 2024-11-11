using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }

        [ForeignKey("Cart")]
        public int CartID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        // Navigation properties
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }

}
