using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Services
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string CustomerAddress { get; set; } = "";

    }
}
