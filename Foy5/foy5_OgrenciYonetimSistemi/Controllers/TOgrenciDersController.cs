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
    public class TOgrenciDersController : Controller
    {
        private readonly Foy5Context _context;

        public TOgrenciDersController(Foy5Context context)
        {
            _context = context;
        }

        // GET: TOgrenciDers
        public async Task<IActionResult> Index()
        {
            var foy5Context = _context.TOgrenciDers.Include(t => t.Ders).Include(t => t.Ogrenci);
            return View(await foy5Context.ToListAsync());
        }

        // GET: TOgrenciDers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenciDer = await _context.TOgrenciDers
                .Include(t => t.Ders)
                .Include(t => t.Ogrenci)
                .FirstOrDefaultAsync(m => m.OgrenciId == id);
            if (tOgrenciDer == null)
            {
                return NotFound();
            }

            return View(tOgrenciDer);
        }

        // GET: TOgrenciDers/Create
        public IActionResult Create()
        {
            ViewData["OgrenciID"] = new SelectList(_context.TOgrencis, "OgrenciId", "Ad");
            ViewData["DersID"] = new SelectList(_context.TDers, "DersId", "DersAd");
            return View();
        }

        // POST: TOgrenciDers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OgrenciId,DersId,Yil,Yariyil,Vize,Final")] TOgrenciDer tOgrenciDer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tOgrenciDer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OgrenciID"] = new SelectList(_context.TOgrencis, "OgrenciId", "Ad", tOgrenciDer.OgrenciId);
            ViewData["DersID"] = new SelectList(_context.TDers, "DersId", "DersAd", tOgrenciDer.DersId);
            return View(tOgrenciDer);
        }


        // GET: TOgrenciDers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenciDer = await _context.TOgrenciDers.FindAsync(id);
            if (tOgrenciDer == null)
            {
                return NotFound();
            }
            ViewData["DersId"] = new SelectList(_context.TDers, "DersId", "DersId", tOgrenciDer.DersId);
            ViewData["OgrenciId"] = new SelectList(_context.TOgrencis, "OgrenciId", "OgrenciId", tOgrenciDer.OgrenciId);
            return View(tOgrenciDer);
        }

        // POST: TOgrenciDers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OgrenciId,DersId,Yil,Yariyil,Vize,Final")] TOgrenciDer tOgrenciDer)
        {
            if (id != tOgrenciDer.OgrenciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tOgrenciDer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TOgrenciDerExists(tOgrenciDer.OgrenciId))
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
            ViewData["DersId"] = new SelectList(_context.TDers, "DersId", "DersId", tOgrenciDer.DersId);
            ViewData["OgrenciId"] = new SelectList(_context.TOgrencis, "OgrenciId", "OgrenciId", tOgrenciDer.OgrenciId);
            return View(tOgrenciDer);
        }

        // GET: TOgrenciDers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOgrenciDer = await _context.TOgrenciDers
                .Include(t => t.Ders)
                .Include(t => t.Ogrenci)
                .FirstOrDefaultAsync(m => m.OgrenciId == id);
            if (tOgrenciDer == null)
            {
                return NotFound();
            }

            return View(tOgrenciDer);
        }

        // POST: TOgrenciDers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tOgrenciDer = await _context.TOgrenciDers.FindAsync(id);
            if (tOgrenciDer != null)
            {
                _context.TOgrenciDers.Remove(tOgrenciDer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TOgrenciDerExists(int id)
        {
            return _context.TOgrenciDers.Any(e => e.OgrenciId == id);
        }
    }
}
