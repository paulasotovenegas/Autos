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
    public class Combustible : ICRUD<data.Combustible>
    {
            private Repository<data.Combustible> _repo = null;

            public Combustible(SolutionDbContext solutionDbContext)
            {
                _repo = new Repository<data.Combustible>(solutionDbContext);
            }
            public void Delete(data.Combustible t)
            {
                _repo.Delete(t);
                _repo.Commit();
            }

            public IEnumerable<data.Combustible> GetAll()
            {
                return _repo.GetAll();
            }

            public Task<IEnumerable<data.Combustible>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Combustible GetOneByID(int id)
            {
                return _repo.GetOneById(id);
            }

            public Task<data.Combustible> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Combustible t)
            {
                _repo.Insert(t);
                _repo.Commit();
            }

            public void Update(data.Combustible t)
            {
                _repo.Update(t);
                _repo.Commit();
            }

        }
    }

