﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Services
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string ProductDescription { get; set; } = "";

        [Required]
        public int ProductQantity { get; set; }

        [Required]
        public int ProductPrice { get; set; }
    }
}
