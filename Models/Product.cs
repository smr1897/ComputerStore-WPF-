
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string ProductDescription { get; set; } = "";

        [Required]
        public int ProductPrice { get; set; }
    }

}
