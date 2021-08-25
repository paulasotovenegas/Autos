using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL.Repository
{
    public interface IRepositoryModelos : IRepository<data.Modelos>
    {

        Task<IEnumerable<data.Modelos>> GetAllWithAsAsync();
        Task<data.Modelos> GetOneByIdAsAsync(int id);
    }
}
