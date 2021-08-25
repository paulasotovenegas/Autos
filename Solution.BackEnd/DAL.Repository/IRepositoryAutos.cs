using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL.Repository
{
    public interface IRepositoryAutos : IRepository<data.Autos>
    {
        Task<IEnumerable<data.Autos>> GetAllWithAsAsync();
        Task<data.Autos> GetOneByIdAsAsync(int id);
    }
}
