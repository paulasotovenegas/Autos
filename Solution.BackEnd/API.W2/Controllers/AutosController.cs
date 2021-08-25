using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.W2.Models;

namespace API.W2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutosController : ControllerBase
    {
        private readonly AutosVentas3Context _context;

        public AutosController(AutosVentas3Context context)
        {
            _context = context;
        }

        // GET: api/Autos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autos>>> GetAutos()
        {
            return await _context.Autos.ToListAsync();
        }

        // GET: api/Autos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autos>> GetAutos(int id)
        {
            var autos = await _context.Autos.FindAsync(id);

            if (autos == null)
            {
                return NotFound();
            }

            return autos;
        }

        // PUT: api/Autos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutos(int id, Autos autos)
        {
            if (id != autos.Id)
            {
                return BadRequest();
            }

            _context.Entry(autos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Autos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Autos>> PostAutos(Autos autos)
        {
            _context.Autos.Add(autos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutos", new { id = autos.Id }, autos);
        }

        // DELETE: api/Autos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Autos>> DeleteAutos(int id)
        {
            var autos = await _context.Autos.FindAsync(id);
            if (autos == null)
            {
                return NotFound();
            }

            _context.Autos.Remove(autos);
            await _context.SaveChangesAsync();

            return autos;
        }

        private bool AutosExists(int id)
        {
            return _context.Autos.Any(e => e.Id == id);
        }
    }
}
