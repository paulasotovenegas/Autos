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
    public class TiposAutos : ICRUD<data.TiposAutos>
    {

            private Repository<data.TiposAutos> _repo = null;

            public TiposAutos(SolutionDbContext solutionDbContext)
            {
                _repo = new Repository<data.TiposAutos>(solutionDbContext);
            }
            public void Delete(data.TiposAutos t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.TiposAutos> GetAll()
            {
                return _repo.GetAll();
            }

            public Task<IEnumerable<data.TiposAutos>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.TiposAutos GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public Task<data.TiposAutos> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.TiposAutos t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.TiposAutos t)
            {
                _repo.Update(t);
                _repo.Commit();
            }

        }
    }

