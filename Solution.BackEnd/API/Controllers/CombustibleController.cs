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
    public class CombustibleController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public CombustibleController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Combustible
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Combustible>>> GetCombustible()
        {
            var res = new BS.Combustible(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.Combustible>, IEnumerable<DataModels.Combustible>>(res).ToList();

            return mapaux;
        }

        // GET: api/Combustible/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Combustible>> GetCombustible(int id)
        {
            var combustible = new BS.Combustible(_context).GetOneByID(id);
            var mapaux = _mapper.Map<data.Combustible, DataModels.Combustible>(combustible);

            if (combustible == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Combustible/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCombustible(int id, DataModels.Combustible combustible)
        {
            if (id != combustible.Id)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.Combustible, data.Combustible>(combustible);
                new BS.Combustible(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!CombustibleExists(id))
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

        // POST: api/Combustible
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Combustible>> PostCombustible(DataModels.Combustible combustible)
        {
            var mapaux = _mapper.Map<DataModels.Combustible, data.Combustible>(combustible);
            new BS.Combustible(_context).Insert(mapaux);

            return CreatedAtAction("GetCombustible", new { id = combustible.Id }, combustible);
        }

        // DELETE: api/Combustible/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Combustible>> DeleteCombustible(int id)
        {
            var combustible = new BS.Combustible(_context).GetOneByID(id);
            if (combustible == null)
            {
                return NotFound();
            }

            new BS.Combustible(_context).Delete(combustible);
            var mapaux = _mapper.Map<data.Combustible, DataModels.Combustible>(combustible);
            return mapaux;
        }

        private bool CombustibleExists(int id)
        {
            return (new BS.Combustible(_context).GetOneByID(id) != null);
        }
    }
}
