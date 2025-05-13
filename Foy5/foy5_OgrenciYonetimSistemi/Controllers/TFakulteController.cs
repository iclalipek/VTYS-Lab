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
    public class TFakulteController : Controller
    {
        private readonly Foy5Context _context;

        public TFakulteController(Foy5Context context)
        {
            _context = context;
        }

        // GET: TFakulte
        public async Task<IActionResult> Index()
        {
            return View(await _context.TFakultes.ToListAsync());
        }

        // GET: TFakulte/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFakulte = await _context.TFakultes
                .FirstOrDefaultAsync(m => m.FakulteId == id);
            if (tFakulte == null)
            {
                return NotFound();
            }

            return View(tFakulte);
        }

        // GET: TFakulte/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TFakulte/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FakulteId,FakulteAd")] TFakulte tFakulte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tFakulte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tFakulte);
        }

        // GET: TFakulte/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFakulte = await _context.TFakultes.FindAsync(id);
            if (tFakulte == null)
            {
                return NotFound();
            }
            return View(tFakulte);
        }

        // POST: TFakulte/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FakulteId,FakulteAd")] TFakulte tFakulte)
        {
            if (id != tFakulte.FakulteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tFakulte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TFakulteExists(tFakulte.FakulteId))
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
            return View(tFakulte);
        }

        // GET: TFakulte/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tFakulte = await _context.TFakultes
                .FirstOrDefaultAsync(m => m.FakulteId == id);
            if (tFakulte == null)
            {
                return NotFound();
            }

            return View(tFakulte);
        }

        // POST: TFakulte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tFakulte = await _context.TFakultes.FindAsync(id);
            if (tFakulte != null)
            {
                _context.TFakultes.Remove(tFakulte);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TFakulteExists(int id)
        {
            return _context.TFakultes.Any(e => e.FakulteId == id);
        }
    }
}
