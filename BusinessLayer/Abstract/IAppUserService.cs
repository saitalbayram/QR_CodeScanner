using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        public bool CheckUser(string userName, string password);
        public int GetUserID(string userName);
    }
}
