using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using foy5_OgrenciYonetimSistemi.Models;

namespace foy5_OgrenciYonetimSistemi.Controllers
{
    public class TBolumController : Controller
    {
        private readonly Foy5Context _context;

        public TBolumController(Foy5Context context)
        {
            _context = context;
        }

        // GET: TBolum
        public async Task<IActionResult> Index()
        {
            var foy5Context = _context.TBolums.Include(t => t.Fakulte);
            return View(await foy5Context.ToListAsync());
        }

        // GET: TBolum/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBolum = await _context.TBolums
                .Include(t => t.Fakulte)
                .FirstOrDefaultAsync(m => m.BolumId == id);
            if (tBolum == null)
            {
                return NotFound();
            }

            return View(tBolum);
        }

        // GET: TBolum/Create
        public IActionResult Create()
        {
            ViewData["FakulteId"] = new SelectList(_context.TFakultes, "FakulteId", "FakulteId");
            return View();
        }

        // POST: TBolum/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BolumId,BolumAd,FakulteId")] TBolum tBolum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBolum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FakulteId"] = new SelectList(_context.TFakultes, "FakulteId", "FakulteId", tBolum.FakulteId);
            return View(tBolum);
        }

        // GET: TBolum/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBolum = await _context.TBolums.FindAsync(id);
            if (tBolum == null)
            {
                return NotFound();
            }
            ViewData["FakulteId"] = new SelectList(_context.TFakultes, "FakulteId", "FakulteId", tBolum.FakulteId);
            return View(tBolum);
        }

        // POST: TBolum/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BolumId,BolumAd,FakulteId")] TBolum tBolum)
        {
            if (id != tBolum.BolumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBolum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBolumExists(tBolum.BolumId))
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
            ViewData["FakulteId"] = new SelectList(_context.TFakultes, "FakulteId", "FakulteId", tBolum.FakulteId);
            return View(tBolum);
        }

        // GET: TBolum/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBolum = await _context.TBolums
                .Include(t => t.Fakulte)
                .FirstOrDefaultAsync(m => m.BolumId == id);
            if (tBolum == null)
            {
                return NotFound();
            }

            return View(tBolum);
        }

        // POST: TBolum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tBolum = await _context.TBolums.FindAsync(id);
            if (tBolum != null)
            {
                _context.TBolums.Remove(tBolum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBolumExists(int id)
        {
            return _context.TBolums.Any(e => e.BolumId == id);
        }
    }
}
