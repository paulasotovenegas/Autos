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
    public class UsersController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public UsersController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/AspNetUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.AspNetUsers>>> GetAspNetUsers()
        {
            var res = new BS.AspNetUsers(_context).GetAll().ToList();

            var mapaux = _mapper.Map<IEnumerable<data.AspNetUsers>, IEnumerable<DataModels.AspNetUsers>>(res).ToList();

            return mapaux;
        }

    }
}
