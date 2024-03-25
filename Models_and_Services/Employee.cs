using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Services
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string EmployeeEmail { get; set; } = "";

        [Required]
        public int salary { get; set; }
    }
}
