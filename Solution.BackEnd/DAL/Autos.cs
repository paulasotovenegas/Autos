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
    public class Autos : ICRUD<data.Autos>
    {
            private RepositoryAutos _repo = null;

            public Autos(SolutionDbContext solutionDbContext)
            {
                _repo = new RepositoryAutos(solutionDbContext);
            }
            public void Delete(data.Autos t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Autos> GetAll()
            {
                return _repo.GetAll();
            }

            public async Task<IEnumerable<data.Autos>> GetAllWithAsync()
            {
                return await _repo.GetAllWithAsAsync();
            }

            public data.Autos GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public async Task<data.Autos> GetOneByIdWithAsync(int id)
            {
                return await _repo.GetOneByIdAsAsync(id);
            }

            public void Insert(data.Autos t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Autos t)
            {
                _repo.Update(t);
                _repo.Commit();
            }
        }
    }

