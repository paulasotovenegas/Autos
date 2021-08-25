using DAL.DO.Interfaces;
using DAL.EF;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL
{

    public class AspNetUsers : ICRUD<data.AspNetUsers>
    {

        private Repository<data.AspNetUsers> _repo = null;

        public AspNetUsers(SolutionDbContext solutionDbContext)
        {
            _repo = new Repository<data.AspNetUsers>(solutionDbContext);
        }
        public void Delete(data.AspNetUsers t)
        {
            _repo.Delete(t);
            _repo.Commit();
        }

        public IEnumerable<data.AspNetUsers> GetAll()
        {
            return _repo.GetAll();
        }

        public Task<IEnumerable<data.AspNetUsers>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public data.AspNetUsers GetOneByID(int id)
        {
            return _repo.GetOneById(id);
        }

        public Task<data.AspNetUsers> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.AspNetUsers t)
        {
            _repo.Insert(t);
            _repo.Commit();
        }

        public void Update(data.AspNetUsers t)
        {
            _repo.Update(t);
            _repo.Commit();
        }

    }
}
