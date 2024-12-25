using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [StringLength(100)]
        [Required]
        public  string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
