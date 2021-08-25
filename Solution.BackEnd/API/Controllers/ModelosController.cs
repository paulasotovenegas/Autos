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
    public class ModelosController : ControllerBase
    {
        private readonly SolutionDbContext _context;

        private readonly IMapper _mapper;

        public ModelosController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Modelos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Modelos>>> GetModelos()
        {
            var res = await new BS.Modelos(_context).GetAllWithAsync();

            var mapaux = _mapper.Map<IEnumerable<data.Modelos>, IEnumerable<DataModels.Modelos>>(res).ToList();

            return mapaux;
        }

        // GET: api/Modelos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Modelos>> GetModelos(int id)
        {
            var modelos = await new BS.Modelos(_context).GetOneByIdWithAsync(id);
            var mapaux = _mapper.Map<data.Modelos, DataModels.Modelos>(modelos);

            if (modelos == null)
            {
                return NotFound();
            }

            return mapaux;
        }

       

        // PUT: api/Modelos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModelos(int id, DataModels.Modelos modelos)
        {
            if (id != modelos.Id)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.Modelos, data.Modelos>(modelos);
                new BS.Modelos(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!ModelosExists(id))
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

        // POST: api/Modelos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Modelos>> PostModelos(DataModels.Modelos modelos)
        {
            var mapaux = _mapper.Map<DataModels.Modelos, data.Modelos>(modelos);
            new BS.Modelos(_context).Insert(mapaux);
            return CreatedAtAction("GetModelos", new { id = modelos.Id }, modelos);
        }

        // DELETE: api/Modelos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Modelos>> DeleteModelos(int id)
        {
            var modelos = new BS.Modelos(_context).GetOneByID(id);
            if (modelos == null)
            {
                return NotFound();
            }

            new BS.Modelos(_context).Delete(modelos);
            var mapaux = _mapper.Map<data.Modelos, DataModels.Modelos>(modelos);
            return mapaux;
        }

        private bool ModelosExists(int id)
        {
            return (new BS.Modelos(_context).GetOneByID(id) != null);
        }
    }
}
