using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.DO.Objects;
using System.Collections.Generic;

namespace DAL.Repository
{
   public class RepositoryModelos : Repository<data.Modelos>, IRepositoryModelos
    {
        public RepositoryModelos(SolutionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Modelos>> GetAllWithAsAsync()
        {
            return await _db.Modelos
                .Include(m => m.Marca)
                .ToListAsync();
        }

        public async Task<Modelos> GetOneByIdAsAsync(int id)
        {
            return await _db.Modelos
               .Include(m => m.Marca)
               .SingleOrDefaultAsync(m => m.Id == id);
        }

       
        private SolutionDbContext _db
        {
            get { return dbContext as SolutionDbContext; }
        }
    }
}
