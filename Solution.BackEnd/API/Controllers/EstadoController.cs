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
    public class EstadoController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public EstadoController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Estado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Estado>>> GetEstado()
        {
            var res = new BS.Estado(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.Estado>, IEnumerable<DataModels.Estado>>(res).ToList();

            return mapaux;
        }

        // GET: api/Estado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Estado>> GetEstado(int id)
        {
            var estado = new BS.Estado(_context).GetOneByID(id);
            var mapaux = _mapper.Map<data.Estado, DataModels.Estado>(estado);

            if (estado == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Estado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstado(int id, DataModels.Estado estado)
        {
            if (id != estado.Id)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.Estado, data.Estado>(estado);
                new BS.Estado(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!EstadoExists(id))
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

        // POST: api/Estado
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Estado>> PostEstado(DataModels.Estado estado)
        {
            var mapaux = _mapper.Map<DataModels.Estado, data.Estado>(estado);
            new BS.Estado(_context).Insert(mapaux);

            return CreatedAtAction("GetEstado", new { id = estado.Id }, estado);
        }

        // DELETE: api/Estado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Estado>> DeleteEstado(int id)
        {
            var estado = new BS.Estado(_context).GetOneByID(id);
            if (estado == null)
            {
                return NotFound();
            }

            new BS.Estado(_context).Delete(estado);
            var mapaux = _mapper.Map<data.Estado, DataModels.Estado>(estado);
            return mapaux;
        }

        private bool EstadoExists(int id)
        {
            return (new BS.Estado(_context).GetOneByID(id) != null);
        }
    }
}
