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
    public class EmployeeJobsController : Controller
    {
        private readonly DomingoRoofWorksContext _context;

        public EmployeeJobsController(DomingoRoofWorksContext context)
        {
            _context = context;
        }

        // GET: EmployeeJobs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeJob.ToListAsync());
        }

        // GET: EmployeeJobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeJob = await _context.EmployeeJob
                .FirstOrDefaultAsync(m => m.EmployeeJobID == id);
            if (employeeJob == null)
            {
                return NotFound();
            }

            return View(employeeJob);
        }

        // GET: EmployeeJobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeJobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeJobID,CardNo,EmployeeID")] EmployeeJob employeeJob)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeJob);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeJob);
        }

        // GET: EmployeeJobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeJob = await _context.EmployeeJob.FindAsync(id);
            if (employeeJob == null)
            {
                return NotFound();
            }
            return View(employeeJob);
        }

        // POST: EmployeeJobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeJobID,CardNo,EmployeeID")] EmployeeJob employeeJob)
        {
            if (id != employeeJob.EmployeeJobID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeJob);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeJobExists(employeeJob.EmployeeJobID))
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
            return View(employeeJob);
        }

        // GET: EmployeeJobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeJob = await _context.EmployeeJob
                .FirstOrDefaultAsync(m => m.EmployeeJobID == id);
            if (employeeJob == null)
            {
                return NotFound();
            }

            return View(employeeJob);
        }

        // POST: EmployeeJobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeJob = await _context.EmployeeJob.FindAsync(id);
            _context.EmployeeJob.Remove(employeeJob);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeJobExists(int id)
        {
            return _context.EmployeeJob.Any(e => e.EmployeeJobID == id);
        }
    }
}
