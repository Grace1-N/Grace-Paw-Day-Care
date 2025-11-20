using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Paw_Day_Care.Data;
using Paw_Day_Care.Models;

namespace Paw_Day_Care.Controllers
{
    public class PetSittersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetSittersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PetSitters
        public async Task<IActionResult> Index()
        {
            return View(await _context.PetSitter.ToListAsync());
        }

        // GET: PetSitters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petSitter = await _context.PetSitter
                .FirstOrDefaultAsync(m => m.petsitterID == id);
            if (petSitter == null)
            {
                return NotFound();
            }

            return View(petSitter);
        }

        // GET: PetSitters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PetSitters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("petsitterID,Name,Service,Area,AvailableTimes,Rating")] PetSitter petSitter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petSitter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petSitter);
        }

        // GET: PetSitters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petSitter = await _context.PetSitter.FindAsync(id);
            if (petSitter == null)
            {
                return NotFound();
            }
            return View(petSitter);
        }

        // POST: PetSitters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("petsitterID,Name,Service,Area,AvailableTimes,Rating")] PetSitter petSitter)
        {
            if (id != petSitter.petsitterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petSitter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetSitterExists(petSitter.petsitterID))
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
            return View(petSitter);
        }

        // GET: PetSitters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petSitter = await _context.PetSitter
                .FirstOrDefaultAsync(m => m.petsitterID == id);
            if (petSitter == null)
            {
                return NotFound();
            }

            return View(petSitter);
        }

        // POST: PetSitters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petSitter = await _context.PetSitter.FindAsync(id);
            if (petSitter != null)
            {
                _context.PetSitter.Remove(petSitter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetSitterExists(int id)
        {
            return _context.PetSitter.Any(e => e.petsitterID == id);
        }
    }
}
