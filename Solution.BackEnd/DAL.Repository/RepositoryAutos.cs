using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.DO.Objects;
using System.Collections.Generic;

namespace DAL.Repository
{
    public class RepositoryAutos : Repository<data.Autos>, IRepositoryAutos
    {

        public RepositoryAutos(SolutionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Autos>> GetAllWithAsAsync()
        {
            return await _db.Autos
                .Include(m => m.Modelo)
                  .Include(m => m.Marca)
                .Include(m => m.Tipo)
                 .Include(m => m.Combustible)
                  .Include(m => m.Transmision)
                   .Include(m => m.Estado)
                   .Include(m => m.User)
                .ToListAsync();
        }

        public async Task<Autos> GetOneByIdAsAsync(int id)
        {
            return await _db.Autos
               .Include(m => m.Modelo)
                .Include(m => m.Marca)
                .Include(m => m.Tipo)
                 .Include(m => m.Combustible)
                  .Include(m => m.Transmision)
                   .Include(m => m.Estado)
                    .Include(m => m.User)
                
               .SingleOrDefaultAsync(m => m.Id == id);
        }

        private SolutionDbContext _db
        {
            get { return dbContext as SolutionDbContext; }
        }

    }
}
