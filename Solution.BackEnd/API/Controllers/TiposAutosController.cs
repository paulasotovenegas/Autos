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
    public class TiposAutosController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public TiposAutosController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/TiposAutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.TiposAutos>>> GetTiposAutos()
        {
            var res = new BS.TiposAutos(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.TiposAutos>, IEnumerable<DataModels.TiposAutos>>(res).ToList();

            return mapaux;
        }

        // GET: api/TiposAutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.TiposAutos>> GetTiposAutos(int id)
        {
            var tiposAutos = new BS.TiposAutos(_context).GetOneByID(id);
            var mapaux = _mapper.Map<data.TiposAutos, DataModels.TiposAutos>(tiposAutos);

            if (tiposAutos == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/TiposAutos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposAutos(int id, DataModels.TiposAutos tiposAutos)
        {
            if (id != tiposAutos.Id)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.TiposAutos, data.TiposAutos>(tiposAutos);
                new BS.TiposAutos(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!TiposAutosExists(id))
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

        // POST: api/TiposAutos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.TiposAutos>> PostTiposAutos(DataModels.TiposAutos tiposAutos)
        {
            var mapaux = _mapper.Map<DataModels.TiposAutos, data.TiposAutos>(tiposAutos);
            new BS.TiposAutos(_context).Insert(mapaux);
            return CreatedAtAction("GetTiposAutos", new { id = tiposAutos.Id }, tiposAutos);
        }

        // DELETE: api/TiposAutos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.TiposAutos>> DeleteTiposAutos(int id)
        {
            var tiposAutos = new BS.TiposAutos(_context).GetOneByID(id);
            if (tiposAutos == null)
            {
                return NotFound();
            }

            new BS.TiposAutos(_context).Delete(tiposAutos);
            var mapaux = _mapper.Map<data.TiposAutos, DataModels.TiposAutos>(tiposAutos);
            return mapaux;
        }

        private bool TiposAutosExists(int id)
        {
            return (new BS.TiposAutos(_context).GetOneByID(id) != null);
        }
    }
}
