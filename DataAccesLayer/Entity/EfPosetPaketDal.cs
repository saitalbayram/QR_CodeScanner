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
    public class EfPosetPaketDal : GenericRepository<PosetPaket>, IPosetPaketDal
    {
       public PosetPaket GetPackFromMaxId()
        {
            using var c = new Context();
            return c.PosetPakets.OrderByDescending(x=> x.ID).FirstOrDefault();
        }
    }
}
