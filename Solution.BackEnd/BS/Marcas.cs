using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class Marcas : ICRUD<data.Marcas>
    {

            private SolutionDbContext context;

            public Marcas(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Marcas t)
            {
                new DAL.Marcas(context).Delete(t);
            }

            public IEnumerable<data.Marcas> GetAll()
            {
                return new DAL.Marcas(context).GetAll();
            }

            public Task<IEnumerable<data.Marcas>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Marcas GetOneByID(int id)
            {
                return new DAL.Marcas(context).GetOneByID(id);
            }

            public Task<data.Marcas> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Marcas t)
            {
                new DAL.Marcas(context).Insert(t);
            }

            public void Update(data.Marcas t)
            {
                new DAL.Marcas(context).Update(t);
            }


        }
    }
