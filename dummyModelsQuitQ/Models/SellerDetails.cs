using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummyModelsQuitQ.Models
{
    public class SellerDetail
    {
        [Key]
        public int SellerDetailID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string CompanyName { get; set; }

        [Required, MaxLength(20)]
        public string GSTNumber { get; set; }

        [MaxLength(255)]
        public string BusinessAddress { get; set; }

        [MaxLength(20)]
        public string BusinessPhone { get; set; }

        [MaxLength(50)]
        public string BankAccountNumber { get; set; }

        [MaxLength(20)]
        public string IFSCCode { get; set; }

        // Navigation property
        public User User { get; set; }
    }

}
