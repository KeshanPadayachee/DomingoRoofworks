using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class Job
    {
        [Key]
        public string CardNo { get; set; }

        [ForeignKey("JobAddressID")]
        public int JobAddressID { get; set; }

        [ForeignKey("RateID")]
        public int RateID { get; set; }

        public int NumberOfDays { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }


    }
}

