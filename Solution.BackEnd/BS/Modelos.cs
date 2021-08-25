using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
   public class Modelos : ICRUD<data.Modelos>
    {
            private SolutionDbContext context;

            public Modelos(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Modelos t)
            {
                new DAL.Modelos(context).Delete(t);
            }

            public IEnumerable<data.Modelos> GetAll()
            {
                return new DAL.Modelos(context).GetAll();
            }

            public async Task<IEnumerable<data.Modelos>> GetAllWithAsync()
            {
                return await new DAL.Modelos(context).GetAllWithAsync();
            }

            public data.Modelos GetOneByID(int id)
            {
                return new DAL.Modelos(context).GetOneByID(id);
            }

            public async Task<data.Modelos> GetOneByIdWithAsync(int id)
            {
                return await new DAL.Modelos(context).GetOneByIdWithAsync(id);
            }

       

        public void Insert(data.Modelos t)
            {
                new DAL.Modelos(context).Insert(t);
            }

            public void Update(data.Modelos t)
            {
                new DAL.Modelos(context).Update(t);
            }

        }
    }
