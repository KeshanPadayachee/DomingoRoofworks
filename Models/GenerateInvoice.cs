using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomingoRoofWorks.Models
{
    public class GenerateInvoice
    {
        public List<JobMaterial> lstJobMaterials = new List<JobMaterial>();
        public List<EmployeeJob> lstEmployeeJob = new List<EmployeeJob>();
        public List<Employee> lstEmployees = new List<Employee>();
        public List<Material> lstMaterials = new List<Material>();

        public Customer customer;
        public Job jobs;
        public JobAddress jobAddress;
        public Rates rates;

        public string subTotal;
        public string VAT;
        public string total;

        public string jobNumber;
    }
}
