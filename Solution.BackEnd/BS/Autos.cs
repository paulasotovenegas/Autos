using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class Autos : ICRUD<data.Autos>
    {
            private SolutionDbContext context;

            public Autos(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Autos t)
            {
                new DAL.Autos(context).Delete(t);
            }

            public IEnumerable<data.Autos> GetAll()
            {
                return new DAL.Autos(context).GetAll();
            }

            public async Task<IEnumerable<data.Autos>> GetAllWithAsync()
            {
                return await new DAL.Autos(context).GetAllWithAsync();
            }

            public data.Autos GetOneByID(int id)
            {
                return new DAL.Autos(context).GetOneByID(id);
            }

            public async Task<data.Autos> GetOneByIdWithAsync(int id)
            {
                return await new DAL.Autos(context).GetOneByIdWithAsync(id);
            }

            public void Insert(data.Autos t)
            {
                new DAL.Autos(context).Insert(t);
            }

            public void Update(data.Autos t)
            {
                new DAL.Autos(context).Update(t);
            }

        }
    }
