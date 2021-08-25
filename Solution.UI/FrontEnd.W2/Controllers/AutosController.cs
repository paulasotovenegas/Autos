using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.W2.Models;

namespace FrontEnd.W2.Controllers
{
    public class AutosController : Controller
    {
        private readonly AutosVentas3Context _context;

        public AutosController(AutosVentas3Context context)
        {
            _context = context;
        }

        // GET: Autos
        public async Task<IActionResult> Index()
        {
            var autosVentas3Context = _context.Autos.Include(a => a.Combustible).Include(a => a.Estado).Include(a => a.Marca).Include(a => a.Modelo).Include(a => a.Tipo).Include(a => a.Transmision).Include(a => a.User);
            return View(await autosVentas3Context.ToListAsync());
        }

        // GET: Autos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos
                .Include(a => a.Combustible)
                .Include(a => a.Estado)
                .Include(a => a.Marca)
                .Include(a => a.Modelo)
                .Include(a => a.Tipo)
                .Include(a => a.Transmision)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }

        // GET: Autos/Create
        public IActionResult Create()
        {
            ViewData["CombustibleId"] = new SelectList(_context.Combustible, "Id", "Id");
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id");
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Id");
            ViewData["ModeloId"] = new SelectList(_context.Modelos, "Id", "Id");
            ViewData["TipoId"] = new SelectList(_context.TiposAutos, "Id", "Id");
            ViewData["TransmisionId"] = new SelectList(_context.Transmisiones, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: Autos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Precio,Anio,UserId,Kilometraje,TerminacionPlaca,Cpuertas,Provincia,Color,FechaIngreso,CombustibleId,EstadoId,MarcaId,ModeloId,TipoId,TransmisionId,Imagen")] Autos autos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CombustibleId"] = new SelectList(_context.Combustible, "Id", "Id", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Id", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Modelos, "Id", "Id", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(_context.TiposAutos, "Id", "Id", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(_context.Transmisiones, "Id", "Id", autos.TransmisionId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", autos.UserId);
            return View(autos);
        }

        // GET: Autos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos.FindAsync(id);
            if (autos == null)
            {
                return NotFound();
            }
            ViewData["CombustibleId"] = new SelectList(_context.Combustible, "Id", "Id", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Id", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Modelos, "Id", "Id", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(_context.TiposAutos, "Id", "Id", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(_context.Transmisiones, "Id", "Id", autos.TransmisionId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", autos.UserId);
            return View(autos);
        }

        // POST: Autos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Precio,Anio,UserId,Kilometraje,TerminacionPlaca,Cpuertas,Provincia,Color,FechaIngreso,CombustibleId,EstadoId,MarcaId,ModeloId,TipoId,TransmisionId,Imagen")] Autos autos)
        {
            if (id != autos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutosExists(autos.Id))
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
            ViewData["CombustibleId"] = new SelectList(_context.Combustible, "Id", "Id", autos.CombustibleId);
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", autos.EstadoId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Id", autos.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Modelos, "Id", "Id", autos.ModeloId);
            ViewData["TipoId"] = new SelectList(_context.TiposAutos, "Id", "Id", autos.TipoId);
            ViewData["TransmisionId"] = new SelectList(_context.Transmisiones, "Id", "Id", autos.TransmisionId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", autos.UserId);
            return View(autos);
        }

        // GET: Autos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos
                .Include(a => a.Combustible)
                .Include(a => a.Estado)
                .Include(a => a.Marca)
                .Include(a => a.Modelo)
                .Include(a => a.Tipo)
                .Include(a => a.Transmision)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }

        // POST: Autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autos = await _context.Autos.FindAsync(id);
            _context.Autos.Remove(autos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutosExists(int id)
        {
            return _context.Autos.Any(e => e.Id == id);
        }
    }
}
