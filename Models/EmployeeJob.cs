using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class EmployeeJob
    {

        [Key]
        public int EmployeeJobID { get; set; }

        [ForeignKey("CardNo")]
        public string CardNo { get; set; }

        [ForeignKey("EmployeeID")]
        public string EmployeeID { get; set;  }
    }
}
