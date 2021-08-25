using DAL.DO.Interfaces;
using DAL.EF;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;


namespace DAL
{
    public class Transmisiones : ICRUD<data.Transmisiones>
    {

            private Repository<data.Transmisiones> _repo = null;

            public Transmisiones(SolutionDbContext solutionDbContext)
            {
                _repo = new Repository<data.Transmisiones>(solutionDbContext);
            }
            public void Delete(data.Transmisiones t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Transmisiones> GetAll()
            {
                return _repo.GetAll();
            }

            public Task<IEnumerable<data.Transmisiones>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Transmisiones GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public Task<data.Transmisiones> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Transmisiones t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Transmisiones t)
            {
                _repo.Update(t);
                _repo.Commit();
            }

        }

    }

