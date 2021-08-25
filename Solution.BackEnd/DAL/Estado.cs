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
    public class Estado : ICRUD<data.Estado>
    {

            private Repository<data.Estado> _repo = null;

            public Estado(SolutionDbContext solutionDbContext)
            {
                _repo = new Repository<data.Estado>(solutionDbContext);
            }
            public void Delete(data.Estado t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Estado> GetAll()
            {
                return _repo.GetAll();
            }

            public Task<IEnumerable<data.Estado>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Estado GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public Task<data.Estado> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Estado t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Estado t)
            {
                _repo.Update(t);
                _repo.Commit();
            }

        }
    }

