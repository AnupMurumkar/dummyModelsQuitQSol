using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class ProductInventory
    {
        [Key]
        public int InventoryID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required]
        public int Stock { get; set; }

        public int ReorderLevel { get; set; } = 10;

        public DateTime? LastRestockedDate { get; set; }

        [MaxLength(20)]
        public string AvailabilityStatus { get; set; } = "In Stock";

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Navigation property
        public Product Product { get; set; }
    }

}
