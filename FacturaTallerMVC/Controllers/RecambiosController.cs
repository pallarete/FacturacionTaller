using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FacturaTallerMVC.Data;
using FacturaTallerMVC.Models;

namespace FacturaTallerMVC.Controllers
{
    public class RecambiosController : Controller
    {
        private readonly DataContext _context;

        public RecambiosController(DataContext context)
        {
            _context = context;
        }

        // GET: Recambios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recambios.ToListAsync());
        }

        // GET: Recambios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recambio = await _context.Recambios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recambio == null)
            {
                return NotFound();
            }

            return View(recambio);
        }

        // GET: Recambios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recambios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Precio")] Recambio recambio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recambio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recambio);
        }

        // GET: Recambios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recambio = await _context.Recambios.FindAsync(id);
            if (recambio == null)
            {
                return NotFound();
            }
            return View(recambio);
        }

        // POST: Recambios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Precio")] Recambio recambio)
        {
            if (id != recambio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recambio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecambioExists(recambio.Id))
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
            return View(recambio);
        }

        // GET: Recambios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recambio = await _context.Recambios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recambio == null)
            {
                return NotFound();
            }

            return View(recambio);
        }

        // POST: Recambios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recambio = await _context.Recambios.FindAsync(id);
            if (recambio != null)
            {
                _context.Recambios.Remove(recambio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecambioExists(int id)
        {
            return _context.Recambios.Any(e => e.Id == id);
        }
    }
}
