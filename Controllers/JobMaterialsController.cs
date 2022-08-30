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
    public class JobMaterialsController : Controller
    {
        private readonly DomingoRoofWorksContext _context;

        public JobMaterialsController(DomingoRoofWorksContext context)
        {
            _context = context;
        }

        // GET: JobMaterials
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobMaterial.ToListAsync());
        }

        // GET: JobMaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobMaterial = await _context.JobMaterial
                .FirstOrDefaultAsync(m => m.JobMaterialID == id);
            if (jobMaterial == null)
            {
                return NotFound();
            }

            return View(jobMaterial);
        }

        // GET: JobMaterials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobMaterialID,CardNo,MaterialID,Quantity")] JobMaterial jobMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobMaterial);
        }

        // GET: JobMaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobMaterial = await _context.JobMaterial.FindAsync(id);
            if (jobMaterial == null)
            {
                return NotFound();
            }
            return View(jobMaterial);
        }

        // POST: JobMaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobMaterialID,CardNo,MaterialID,Quantity")] JobMaterial jobMaterial)
        {
            if (id != jobMaterial.JobMaterialID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobMaterialExists(jobMaterial.JobMaterialID))
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
            return View(jobMaterial);
        }

        // GET: JobMaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobMaterial = await _context.JobMaterial
                .FirstOrDefaultAsync(m => m.JobMaterialID == id);
            if (jobMaterial == null)
            {
                return NotFound();
            }

            return View(jobMaterial);
        }

        // POST: JobMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobMaterial = await _context.JobMaterial.FindAsync(id);
            _context.JobMaterial.Remove(jobMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobMaterialExists(int id)
        {
            return _context.JobMaterial.Any(e => e.JobMaterialID == id);
        }
    }
}
