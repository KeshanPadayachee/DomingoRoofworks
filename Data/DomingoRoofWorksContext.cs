using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomingoRoofWorks.Models;

namespace DomingoRoofWorks.Data
{
    public class DomingoRoofWorksContext : DbContext
    {
        public DomingoRoofWorksContext (DbContextOptions<DomingoRoofWorksContext> options)
            : base(options)
        {
        }

        public DbSet<DomingoRoofWorks.Models.Rates> Rates { get; set; }

        public DbSet<DomingoRoofWorks.Models.Material> Material { get; set; }

        public DbSet<DomingoRoofWorks.Models.JobMaterial> JobMaterial { get; set; }

        public DbSet<DomingoRoofWorks.Models.JobAddress> JobAddress { get; set; }

        public DbSet<DomingoRoofWorks.Models.Job> Job { get; set; }

        public DbSet<DomingoRoofWorks.Models.EmployeeJob> EmployeeJob { get; set; }

        public DbSet<DomingoRoofWorks.Models.Customer> Customer { get; set; }

        public DbSet<DomingoRoofWorks.Models.Employee> Employee { get; set; }
    }
}
