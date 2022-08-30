using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DomingoRoofWorks.Data;
using DomingoRoofWorks.Models;

namespace DomingoRoofWorks.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly DomingoRoofWorksContext _context;

        public InvoiceController(DomingoRoofWorksContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
           
        }
        // GET: Invoice
        public async Task<IActionResult> Display(string cardNo)
        {
            
            
            if (cardNo == null)
            {
                return NotFound();
                
            }
            List<JobMaterial> lstJobMaterials = new List<JobMaterial>();
            List<EmployeeJob> lstEmployeeJob = new List<EmployeeJob>();
            List<Employee> lstEmployees = new List<Employee>();
            List<Material> lstMaterials = new List<Material>();
            List<Customer> lstCustomer = new List<Customer>();
            List<Job> lstJob = new List<Job>();
            List<JobAddress> lstJobAddresses = new List<JobAddress>();
            List<Rates> lstRates = new List<Rates>();

            lstJobMaterials = _context.JobMaterial.ToList();
            lstEmployeeJob = _context.EmployeeJob.ToList();
            lstEmployees = _context.Employee.ToList();
            lstMaterials = _context.Material.ToList();
            lstCustomer = _context.Customer.ToList();
            lstJob = _context.Job.ToList();
            lstJobAddresses = _context.JobAddress.ToList();
            lstRates = _context.Rates.ToList();

            GenerateInvoice genInv = new GenerateInvoice();

            genInv.jobNumber = cardNo;
            foreach (Job jobItem in lstJob)
            {
                if (jobItem.CardNo.Equals(cardNo))
                {
                    genInv.jobs = jobItem;
                    foreach (JobAddress jobAdd in lstJobAddresses)
                    {
                        if (jobItem.JobAddressID.Equals(jobAdd.JobAddressID))
                        {
                            genInv.jobAddress = jobAdd;
                        }
                    } // End of for each
                    foreach (Rates rate in lstRates)
                    {
                        if (jobItem.RateID.Equals(rate.RateID))
                        {
                            genInv.rates = rate;
                            double subtotal = rate.Rate * jobItem.NumberOfDays;
                            genInv.subTotal = Convert.ToString(subtotal);

                            double VaT = 0.15 * subtotal;
                            genInv.VAT = Convert.ToString(VaT);

                            genInv.total = Convert.ToString(subtotal+VaT);
                        }
                    } // End of for each
                    foreach (Customer cust in lstCustomer)
                    {
                        if (jobItem.CustomerID.Equals(cust.CustomerID))
                        {
                            genInv.customer = cust;
                        }
                    } // End of for each

                    foreach (JobMaterial quantity in lstJobMaterials)
                    {
                        if (jobItem.CardNo.Equals(quantity.CardNo))
                        {
                            genInv.lstJobMaterials.Add(quantity);
                            foreach (Material materials in lstMaterials)
                            {
                                if (materials.MaterialID.Equals(quantity.MaterialID))
                                {
                                    genInv.lstMaterials.Add(materials);
                                }
                            } // End of for each
                        } // End of if 
                    } // End of foreach

                    foreach (EmployeeJob empJob in lstEmployeeJob)
                    {
                        if (jobItem.CardNo.Equals(empJob.CardNo))
                        {
                            genInv.lstEmployeeJob.Add(empJob);
                            foreach (Employee emp in lstEmployees)
                            {
                                if (empJob.EmployeeID.Equals(emp.EmployeeID))
                                {
                                    genInv.lstEmployees.Add(emp);
                                } // End of if 
                            } // End of for each
                        } // End of if
                    } // End of for each
                } // End of If
            } // End of for each

         

            return View(genInv);
        }

        // GET: Invoice/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .FirstOrDefaultAsync(m => m.CardNo == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Invoice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardNo,JobAddressID,RateID,NumberOfDays,CustomerID")] Job job)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Invoice/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        // POST: Invoice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CardNo,JobAddressID,RateID,NumberOfDays,CustomerID")] Job job)
        {
            if (id != job.CardNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.CardNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Invoice/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .FirstOrDefaultAsync(m => m.CardNo == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Invoice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var job = await _context.Job.FindAsync(id);
            _context.Job.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(string id)
        {
            return _context.Job.Any(e => e.CardNo == id);
        }
    }
}
