using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class Combustible : ICRUD<data.Combustible>
    {
            private SolutionDbContext context;

            public Combustible(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Combustible t)
            {
                new DAL.Combustible(context).Delete(t);
            }

            public IEnumerable<data.Combustible> GetAll()
            {
                return new DAL.Combustible(context).GetAll();
            }

            public Task<IEnumerable<data.Combustible>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Combustible GetOneByID(int id)
            {
                return new DAL.Combustible(context).GetOneByID(id);
            }

            public Task<data.Combustible> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Combustible t)
            {
                new DAL.Combustible(context).Insert(t);
            }

            public void Update(data.Combustible t)
            {
                new DAL.Combustible(context).Update(t);
            }


        }
    }
