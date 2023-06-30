using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConversordeMonedaWEB.Models;
using Negocio;

namespace ConversordeMonedaWEB.Controllers
{
    public class MonedasEditorController : Controller
    {
        private readonly ContextoDatos _context;

        public MonedasEditorController(ContextoDatos context)
        {
            _context = context;
        }

        // GET: MonedasEditor
        public async Task<IActionResult> Index()
        {
              return _context.Monedas != null ? 
                          View(await _context.Monedas.ToListAsync()) :
                          Problem("Entity set 'ContextoDatos.Monedas'  is null.");
        }

        // GET: MonedasEditor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Monedas == null)
            {
                return NotFound();
            }

            var moneda = await _context.Monedas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moneda == null)
            {
                return NotFound();
            }

            return View(moneda);
        }

        // GET: MonedasEditor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MonedasEditor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Sigla,Id")] Moneda moneda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moneda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moneda);
        }

        // GET: MonedasEditor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Monedas == null)
            {
                return NotFound();
            }

            var moneda = await _context.Monedas.FindAsync(id);
            if (moneda == null)
            {
                return NotFound();
            }
            return View(moneda);
        }

        // POST: MonedasEditor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Bind("Nombre,Sigla,Id")
        public async Task<IActionResult> Edit(int id, Moneda moneda)
        {
            if (id != moneda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moneda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonedaExists(moneda.Id))
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
            return View(moneda);
        }

        // GET: MonedasEditor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Monedas == null)
            {
                return NotFound();
            }

            var moneda = await _context.Monedas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moneda == null)
            {
                return NotFound();
            }

            return View(moneda);
        }

        // POST: MonedasEditor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Monedas == null)
            {
                return Problem("Entity set 'ContextoDatos.Monedas'  is null.");
            }
            var moneda = await _context.Monedas.FindAsync(id);
            if (moneda != null)
            {
                _context.Monedas.Remove(moneda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonedaExists(int id)
        {
          return (_context.Monedas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
