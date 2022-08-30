using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class Rates
    {
        [Key]
        public int RateID { get; set; }

        public string Type { get; set; }

        public double Rate { get; set; }
    }
}
