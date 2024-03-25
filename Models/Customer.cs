using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string CustomerAddress { get; set; } = "";

        [Required]
        [StringLength(10)]
        //[Phone]
        public string CustomerPhoneNumber { get; set; } = "";
    }
}
