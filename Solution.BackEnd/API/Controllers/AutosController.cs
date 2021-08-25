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
    public class AutosController : ControllerBase
    {
        private readonly SolutionDbContext _context;

        private readonly IMapper _mapper;

        public AutosController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Autos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Autos>>> GetAutos()
        {
            var res = await new BS.Autos(_context).GetAllWithAsync();

            var mapaux = _mapper.Map<IEnumerable<data.Autos>, IEnumerable<DataModels.Autos>>(res).ToList();

            return mapaux;
        }

        // GET: api/Autos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Autos>> GetAutos(int id)
        {
            var autos = await new BS.Autos(_context).GetOneByIdWithAsync(id);
            var mapaux = _mapper.Map<data.Autos, DataModels.Autos>(autos);

            if (autos == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Autos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutos(int id, DataModels.Autos autos)
        {
            if (id != autos.Id)
            {
                return BadRequest();
            }


            try
            {
                var mapaux = _mapper.Map<DataModels.Autos, data.Autos>(autos);
                new BS.Autos(_context).Update(mapaux);
            }
            catch (Exception ee)
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
        public async Task<ActionResult<DataModels.Autos>> PostAutos(DataModels.Autos autos)
        {
            var mapaux = _mapper.Map<DataModels.Autos, data.Autos>(autos);
            new BS.Autos(_context).Insert(mapaux);
            return CreatedAtAction("GetAutos", new { id = autos.Id }, autos);
        }

        // DELETE: api/Autos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Autos>> DeleteAutos(int id)
        {
            var autos = new BS.Autos(_context).GetOneByID(id);
            if (autos == null)
            {
                return NotFound();
            }

            new BS.Autos(_context).Delete(autos);
            var mapaux = _mapper.Map<data.Autos, DataModels.Autos>(autos);
            return mapaux;
        }

        private bool AutosExists(int id)
        {
            return (new BS.Autos(_context).GetOneByID(id) != null);
        }
    }
}
