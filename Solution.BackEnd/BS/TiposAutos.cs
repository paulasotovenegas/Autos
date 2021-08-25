using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class TiposAutos : ICRUD<data.TiposAutos>
    {

            private SolutionDbContext context;

            public TiposAutos(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.TiposAutos t)
            {
                new DAL.TiposAutos(context).Delete(t);
            }

            public IEnumerable<data.TiposAutos> GetAll()
            {
                return new DAL.TiposAutos(context).GetAll();
            }

            public Task<IEnumerable<data.TiposAutos>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.TiposAutos GetOneByID(int id)
            {
                return new DAL.TiposAutos(context).GetOneByID(id);
            }

            public Task<data.TiposAutos> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.TiposAutos t)
            {
                new DAL.TiposAutos(context).Insert(t);
            }

            public void Update(data.TiposAutos t)
            {
                new DAL.TiposAutos(context).Update(t);
            }


        }
    }
