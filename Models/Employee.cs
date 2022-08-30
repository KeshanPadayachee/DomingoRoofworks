using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }

        public string FullName { get; set; }
    }
}
