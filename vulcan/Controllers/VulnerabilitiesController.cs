using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vulcan.Models;

namespace vulcan.Controllers
{
    public class VulnerabilitiesController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        private readonly vulcanContext _context;

        public VulnerabilitiesController(vulcanContext context)
        {
            _context = context;
        }

        // GET: Vulnerabilities
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Vulnerabilidades";
            return View(await _context.Vulnerabilities.ToListAsync());
        }

        // GET: Vulnerabilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulnerabilities = await _context.Vulnerabilities
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vulnerabilities == null)
            {
                return NotFound();
            }

            return View(vulnerabilities);
        }

        // GET: Vulnerabilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vulnerabilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Product,Version,VulnerabilitieID,VulnerabilitieName,ConfidentialityImpact,IntegrityImpact,AvaliabilityImpact,AccessComplexity,Authentication,GainedAccess,Type,Score,Gravity,Description")] Vulnerabilities vulnerabilities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vulnerabilities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vulnerabilities);
        }

        // GET: Vulnerabilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulnerabilities = await _context.Vulnerabilities.FindAsync(id);
            if (vulnerabilities == null)
            {
                return NotFound();
            }
            return View(vulnerabilities);
        }

        // POST: Vulnerabilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Product,Version,VulnerabilitieID,VulnerabilitieName,ConfidentialityImpact,IntegrityImpact,AvaliabilityImpact,AccessComplexity,Authentication,GainedAccess,Type,Score,Gravity,Description")] Vulnerabilities vulnerabilities)
        {
            if (id != vulnerabilities.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vulnerabilities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VulnerabilitiesExists(vulnerabilities.ID))
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
            return View(vulnerabilities);
        }

        // GET: Vulnerabilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulnerabilities = await _context.Vulnerabilities
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vulnerabilities == null)
            {
                return NotFound();
            }

            return View(vulnerabilities);
        }

        // POST: Vulnerabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vulnerabilities = await _context.Vulnerabilities.FindAsync(id);
            _context.Vulnerabilities.Remove(vulnerabilities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VulnerabilitiesExists(int id)
        {
            return _context.Vulnerabilities.Any(e => e.ID == id);
        }
    }
}
