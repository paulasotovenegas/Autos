using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class Estado : ICRUD<data.Estado>
    {
            private SolutionDbContext context;

            public Estado(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Estado t)
            {
                new DAL.Estado(context).Delete(t);
            }

            public IEnumerable<data.Estado> GetAll()
            {
                return new DAL.Estado(context).GetAll();
            }

            public Task<IEnumerable<data.Estado>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Estado GetOneByID(int id)
            {
                return new DAL.Estado(context).GetOneByID(id);
            }

            public Task<data.Estado> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Estado t)
            {
                new DAL.Estado(context).Insert(t);
            }

            public void Update(data.Estado t)
            {
                new DAL.Estado(context).Update(t);
            }


        }
    }
