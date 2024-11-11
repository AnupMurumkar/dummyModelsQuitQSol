using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public decimal TotalAmount { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }

}
