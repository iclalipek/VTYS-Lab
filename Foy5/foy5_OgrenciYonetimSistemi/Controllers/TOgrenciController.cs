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
    public class TOgrenciController : Controller
    {
        private readonly Foy5Context _context;

        public TOgrenciController(Foy5Context context)
        {
            _context = context;
        }

        // GET: TOgrenci
        public async Task<IActionResult> Index()
        {
            var foy5Context = _context.TOgrencis.Include(t => t.Bolum);
            return View(await foy5Context.ToListAsync());
        }

        // GET: TOgrenci/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenci = await _context.TOgrencis
                .Include(t => t.Bolum)
                .FirstOrDefaultAsync(m => m.OgrenciId == id);
            if (tOgrenci == null)
            {
                return NotFound();
            }

            return View(tOgrenci);
        }

        // GET: TOgrenci/Create
        public IActionResult Create()
        {
            ViewData["BolumId"] = new SelectList(_context.TBolums, "BolumId", "BolumId");
            return View();
        }

        // POST: TOgrenci/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OgrenciId,Ad,Soyad,BolumId")] TOgrenci tOgrenci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tOgrenci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BolumId"] = new SelectList(_context.TBolums, "BolumId", "BolumId", tOgrenci.BolumId);
            return View(tOgrenci);
        }

        // GET: TOgrenci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenci = await _context.TOgrencis.FindAsync(id);
            if (tOgrenci == null)
            {
                return NotFound();
            }
            ViewData["BolumId"] = new SelectList(_context.TBolums, "BolumId", "BolumId", tOgrenci.BolumId);
            return View(tOgrenci);
        }

        // POST: TOgrenci/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OgrenciId,Ad,Soyad,BolumId")] TOgrenci tOgrenci)
        {
            if (id != tOgrenci.OgrenciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tOgrenci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TOgrenciExists(tOgrenci.OgrenciId))
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
            ViewData["BolumId"] = new SelectList(_context.TBolums, "BolumId", "BolumId", tOgrenci.BolumId);
            return View(tOgrenci);
        }

        // GET: TOgrenci/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenci = await _context.TOgrencis
                .Include(t => t.Bolum)
                .FirstOrDefaultAsync(m => m.OgrenciId == id);
            if (tOgrenci == null)
            {
                return NotFound();
            }

            return View(tOgrenci);
        }

        // POST: TOgrenci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tOgrenci = await _context.TOgrencis.FindAsync(id);
            if (tOgrenci != null)
            {
                _context.TOgrencis.Remove(tOgrenci);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TOgrenciExists(int id)
        {
            return _context.TOgrencis.Any(e => e.OgrenciId == id);
        }
    }
}
