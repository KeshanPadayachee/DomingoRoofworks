using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class JobAddress
    {
        [Key]
        public int JobAddressID { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Province { get; set; }

        public string StreetName { get; set; }

        public string HouseNumber { get; set; }
    }
}
