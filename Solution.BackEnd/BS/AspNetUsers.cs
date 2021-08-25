using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
namespace BS
{

   public class AspNetUsers : ICRUD<data.AspNetUsers>
    {
        private SolutionDbContext context;

        public AspNetUsers(SolutionDbContext _context)
        {
            context = _context;
        }
        public void Delete(data.AspNetUsers t)
        {
            new DAL.AspNetUsers(context).Delete(t);
        }

        public IEnumerable<data.AspNetUsers> GetAll()
        {
            return new DAL.AspNetUsers(context).GetAll();
        }

        public Task<IEnumerable<data.AspNetUsers>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public data.AspNetUsers GetOneByID(int id)
        {
            return new DAL.AspNetUsers(context).GetOneByID(id);
        }

        public Task<data.AspNetUsers> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.AspNetUsers t)
        {
            new DAL.AspNetUsers(context).Insert(t);
        }

        public void Update(data.AspNetUsers t)
        {
            new DAL.AspNetUsers(context).Update(t);
        }


    }
}
