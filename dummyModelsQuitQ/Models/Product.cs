using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; }
    }

}
