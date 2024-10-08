﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class IPosetPaketManager(IPosetPaketDal posetPaketDal) : IPosetPaketService
    {
        IPosetPaketDal _posetPaketDal = posetPaketDal;

        public PosetPaket GetPackFromMaxId()
        {
            return _posetPaketDal.GetPackFromMaxId();
        }

        public void TDelete(PosetPaket t)
        {
            _posetPaketDal.TDelete(t);
        }

        public PosetPaket? TGetById(int? id)
        {
            return _posetPaketDal.TGetById(id);
        }

        public List<PosetPaket> TGetList()
        {
            return _posetPaketDal.TGetList();
        }

        public void TInsert(PosetPaket t)
        {
            _posetPaketDal.TInsert(t);
        }

        public void TUpdate(PosetPaket t)
        {
            _posetPaketDal.TUpdate(t);
        }
    }
}
