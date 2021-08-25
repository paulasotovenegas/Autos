using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
namespace BS
{
  public class Transmisiones : ICRUD<data.Transmisiones>
    {
            private SolutionDbContext context;

            public Transmisiones(SolutionDbContext _context)
            {
                context = _context;
            }
            public void Delete(data.Transmisiones t)
            {
                new DAL.Transmisiones(context).Delete(t);
            }

            public IEnumerable<data.Transmisiones> GetAll()
            {
                return new DAL.Transmisiones(context).GetAll();
            }

            public Task<IEnumerable<data.Transmisiones>> GetAllWithAsync()
            {
                throw new NotImplementedException();
            }

            public data.Transmisiones GetOneByID(int id)
            {
                return new DAL.Transmisiones(context).GetOneByID(id);
            }

            public Task<data.Transmisiones> GetOneByIdWithAsync(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(data.Transmisiones t)
            {
                new DAL.Transmisiones(context).Insert(t);
            }

            public void Update(data.Transmisiones t)
            {
                new DAL.Transmisiones(context).Update(t);
            }


        }
    }
