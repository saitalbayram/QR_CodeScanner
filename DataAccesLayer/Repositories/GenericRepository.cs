using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void TDelete(T t)
        {
            using var c = new Context();
            c.RemoveRange(t);
            c.SaveChanges();
        }

        public T? TGetById(int? id)
        {
            if (id.HasValue)
            {
                using var c = new Context();
                return c.Set<T>().Find(id.Value);
            }
            else
            {
                return null;
            }
        }

        public List<T> TGetList()
        {
            using var c = new Context();
            return [.. c.Set<T>()];
        }


        public void TInsert(List<T> t)
        {
            using var c = new Context();
            c.AddRange(t);
            c.SaveChanges();
        }

        public void TUpdate(T t)
        {
            using var c = new Context();
            c.UpdateRange(t);
            c.SaveChanges();
        }
    }
}
