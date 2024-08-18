using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entity
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public bool CheckUser(string userName, string password)
        {
            using var c = new Context();
            var user = c.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
            return user != null;
        }

        public int GetUserID(string userName)
        {
            using var c = new Context();
            return c.Users.Where(x=> x.UserName == userName).Select(x => x.ID).FirstOrDefault();   
        }
    }
}
