﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T: class
    {
        void TInsert(List<T> t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetList();
        T? TGetById(int? id);

    }
}
