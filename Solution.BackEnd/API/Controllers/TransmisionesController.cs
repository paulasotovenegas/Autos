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
    public class TransmisionesController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public TransmisionesController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Transmisiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Transmisiones>>> GetTransmisiones()
        {
            var res = new BS.Transmisiones(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.Transmisiones>, IEnumerable<DataModels.Transmisiones>>(res).ToList();

            return mapaux;
        }

        // GET: api/Transmisiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Transmisiones>> GetTransmisiones(int id)
        {
            var transmisiones = new BS.Transmisiones(_context).GetOneByID(id);
            var mapaux = _mapper.Map<data.Transmisiones, DataModels.Transmisiones>(transmisiones);

            if (transmisiones == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Transmisiones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransmisiones(int id, DataModels.Transmisiones transmisiones)
        {
            if (id != transmisiones.Id)
            {
                return BadRequest();
            }


            try
            {
                var mapaux = _mapper.Map<DataModels.Transmisiones, data.Transmisiones>(transmisiones);
                new BS.Transmisiones(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!TransmisionesExists(id))
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

        // POST: api/Transmisiones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Transmisiones>> PostTransmisiones(DataModels.Transmisiones transmisiones)
        {
            var mapaux = _mapper.Map<DataModels.Transmisiones, data.Transmisiones>(transmisiones);
            new BS.Transmisiones(_context).Insert(mapaux);
            return CreatedAtAction("GetTransmisiones", new { id = transmisiones.Id }, transmisiones);
        }

        // DELETE: api/Transmisiones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Transmisiones>> DeleteTransmisiones(int id)
        {
            var transmisiones = new BS.Transmisiones(_context).GetOneByID(id);
            if (transmisiones == null)
            {
                return NotFound();
            }
            new BS.Transmisiones(_context).Delete(transmisiones);
            var mapaux = _mapper.Map<data.Transmisiones, DataModels.Transmisiones>(transmisiones);
            return mapaux;
        }

        private bool TransmisionesExists(int id)
        {
            return (new BS.Transmisiones(_context).GetOneByID(id) != null);
        }
    }
}
