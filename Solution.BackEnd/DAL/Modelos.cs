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
    public class Modelos : ICRUD<data.Modelos>
    {

            private RepositoryModelos _repo = null;

            public Modelos(SolutionDbContext solutionDbContext)
            {
                _repo = new RepositoryModelos(solutionDbContext);
            }
            public void Delete(data.Modelos t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Modelos> GetAll()
            {
                return _repo.GetAll();
            }

            public async Task<IEnumerable<data.Modelos>> GetAllWithAsync()
            {
                return await _repo.GetAllWithAsAsync();
            }

            public data.Modelos GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public async Task<data.Modelos> GetOneByIdWithAsync(int id)
            {
                return await _repo.GetOneByIdAsAsync(id);
            }

       

        public void Insert(data.Modelos t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Modelos t)
            {
                _repo.Update(t);
                _repo.Commit();
            }
        }
    }

