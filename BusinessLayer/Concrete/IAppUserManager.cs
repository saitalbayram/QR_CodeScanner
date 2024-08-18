using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class IAppUserManager(IAppUserDal appUserDal) : IAppUserService
    {
        IAppUserDal _appUserDal = appUserDal;

        public bool CheckUser(string userName, string password)
        {
            return _appUserDal.CheckUser(userName, password);
        }

        public int GetUserID(string userName)
        {
            return _appUserDal.GetUserID(userName);
        }

        public void TDelete(AppUser t)
        {
            _appUserDal.TDelete(t);
        }

        public AppUser? TGetById(int? id)
        {
            return _appUserDal.TGetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.TGetList();
        }

        public void TInsert(AppUser t)
        {
            _appUserDal.TInsert(t);
        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.TUpdate(t);
        }
    }
}
