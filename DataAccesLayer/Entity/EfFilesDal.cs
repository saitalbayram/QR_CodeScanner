﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entity
{
    public class EfFilesDal : GenericRepository<Files> ,IFilesDal
    {
    }
}
