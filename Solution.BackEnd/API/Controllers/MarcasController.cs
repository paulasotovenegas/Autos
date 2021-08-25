using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using DAL.EF;
using AutoMapper;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public MarcasController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Marcas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Marcas>>> GetMarcas()
        {
            var res = new BS.Marcas(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.Marcas>, IEnumerable<DataModels.Marcas>>(res).ToList();

            return mapaux;
        }

        // GET: api/Marcas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Marcas>> GetMarcas(int id)
        {
            var marcas = new BS.Marcas(_context).GetOneByID(id);
            var mapaux = _mapper.Map<data.Marcas, DataModels.Marcas>(marcas);

            if (marcas == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Marcas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcas(int id, DataModels.Marcas marcas)
        {
            if (id != marcas.Id)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.Marcas, data.Marcas>(marcas);
                new BS.Marcas(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!MarcasExists(id))
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

        // POST: api/Marcas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Marcas>> PostMarcas(DataModels.Marcas marcas)
        {

            var mapaux = _mapper.Map<DataModels.Marcas, data.Marcas>(marcas);
            new BS.Marcas(_context).Insert(mapaux);
            return CreatedAtAction("GetMarcas", new { id = marcas.Id }, marcas);
        }

        // DELETE: api/Marcas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Marcas>> DeleteMarcas(int id)
        {
            var marcas = new BS.Marcas(_context).GetOneByID(id);
            if (marcas == null)
            {
                return NotFound();
            }

            new BS.Marcas(_context).Delete(marcas);
            var mapaux = _mapper.Map<data.Marcas, DataModels.Marcas>(marcas);
            return mapaux;
        }

        private bool MarcasExists(int id)
        {
            return (new BS.Marcas(_context).GetOneByID(id) != null);
        }
    }
}
