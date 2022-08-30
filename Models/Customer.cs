using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }
    }

    
}
