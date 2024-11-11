
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dummyModelsQuitQ.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required, MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [Required, MaxLength(20)]
        public string Role { get; set; } // Customer, Seller, Admin

        [MaxLength(50)]
        public string Status { get; set; } = "Active";

        // Navigation properties
        public ICollection<SellerDetail> SellerDetails { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Category> CategoriesCreated { get; set; }
    }
}