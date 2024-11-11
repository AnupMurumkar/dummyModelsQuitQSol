using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [ForeignKey("User")]
        public int CreatedByUserID { get; set; }

        public DateTime LastModifiedDate { get; set; } = DateTime.Now;

        // Navigation property
        public User CreatedByUser { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}
