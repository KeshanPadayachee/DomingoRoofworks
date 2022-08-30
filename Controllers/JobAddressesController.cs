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
    public class JobAddressesController : Controller
    {
        private readonly DomingoRoofWorksContext _context;

        public JobAddressesController(DomingoRoofWorksContext context)
        {
            _context = context;
        }

        // GET: JobAddresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobAddress.ToListAsync());
        }

        // GET: JobAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobAddress = await _context.JobAddress
                .FirstOrDefaultAsync(m => m.JobAddressID == id);
            if (jobAddress == null)
            {
                return NotFound();
            }

            return View(jobAddress);
        }

        // GET: JobAddresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobAddressID,City,PostalCode,Province,StreetName,HouseNumber")] JobAddress jobAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobAddress);
        }

        // GET: JobAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobAddress = await _context.JobAddress.FindAsync(id);
            if (jobAddress == null)
            {
                return NotFound();
            }
            return View(jobAddress);
        }

        // POST: JobAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobAddressID,City,PostalCode,Province,StreetName,HouseNumber")] JobAddress jobAddress)
        {
            if (id != jobAddress.JobAddressID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobAddressExists(jobAddress.JobAddressID))
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
            return View(jobAddress);
        }

        // GET: JobAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobAddress = await _context.JobAddress
                .FirstOrDefaultAsync(m => m.JobAddressID == id);
            if (jobAddress == null)
            {
                return NotFound();
            }

            return View(jobAddress);
        }

        // POST: JobAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobAddress = await _context.JobAddress.FindAsync(id);
            _context.JobAddress.Remove(jobAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobAddressExists(int id)
        {
            return _context.JobAddress.Any(e => e.JobAddressID == id);
        }
    }
}
