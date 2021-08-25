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
    public class Marcas : ICRUD<data.Marcas>
    {

            private Repository<data.Marcas> _repo = null;

            public Marcas(SolutionDbContext solutionDbContext)
            {
                _repo = new Repository<data.Marcas>(solutionDbContext);
            }
            public void Delete(data.Marcas t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Marcas> GetAll()
            {
                return _repo.GetAll();
            }

            public Task<IEnumerable<data.Marcas>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Marcas GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public Task<data.Marcas> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Marcas t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Marcas t)
            {
                _repo.Update(t);
                _repo.Commit();
            }

        }
    }

