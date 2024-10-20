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
    public class FacturasController : Controller
    {
        private readonly DataContext _context;

        public FacturasController(DataContext context)
        {
            _context = context;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Facturas.Include(f => f.Cliente).Include(f => f.Coche).Include(f => f.Recambio);
            return View(await dataContext.ToListAsync());
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Cliente)
                .Include(f => f.Coche)
                .Include(f => f.Recambio)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente");
            ViewData["CocheId"] = new SelectList(_context.Coches, "IdCoche", "Marca");
            ViewData["RecambioId"] = new SelectList(_context.Recambios, "IdRecambio", "IdRecambio");
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFactura,ClienteId,CocheId,RecambioId,Piezas,TotalPiezas,Trabajos,HorasTaller,TotalHoras,Pvp,Fecha")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente", factura.ClienteId);
            ViewData["CocheId"] = new SelectList(_context.Coches, "IdCoche", "Marca", factura.CocheId);
            ViewData["RecambioId"] = new SelectList(_context.Recambios, "IdRecambio", "IdRecambio", factura.RecambioId);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente", factura.ClienteId);
            ViewData["CocheId"] = new SelectList(_context.Coches, "IdCoche", "Marca", factura.CocheId);
            ViewData["RecambioId"] = new SelectList(_context.Recambios, "IdRecambio", "IdRecambio", factura.RecambioId);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFactura,ClienteId,CocheId,RecambioId,Piezas,TotalPiezas,Trabajos,HorasTaller,TotalHoras,Pvp,Fecha")] Factura factura)
        {
            if (id != factura.IdFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.IdFactura))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente", factura.ClienteId);
            ViewData["CocheId"] = new SelectList(_context.Coches, "IdCoche", "Marca", factura.CocheId);
            ViewData["RecambioId"] = new SelectList(_context.Recambios, "IdRecambio", "IdRecambio", factura.RecambioId);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Cliente)
                .Include(f => f.Coche)
                .Include(f => f.Recambio)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            if (factura != null)
            {
                _context.Facturas.Remove(factura);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturaExists(int id)
        {
            return _context.Facturas.Any(e => e.IdFactura == id);
        }
    }
}
