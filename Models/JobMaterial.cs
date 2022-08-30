using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class JobMaterial
    {
        [Key]
        public int JobMaterialID { get; set; }

        [ForeignKey("CardNo")]
        public string CardNo { get; set; }

        [ForeignKey("MaterialID")]
        public int MaterialID { get; set; }

        public int Quantity { get; set; }
    }
}
