using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class IFilesManager(IFilesDal filesDal) : IFilesService
    {
        IFilesService _filesService;
        public void TDelete(Files t)
        {
            _filesService.TDelete(t);
        }

        public Files? TGetById(int? id)
        {
            return _filesService.TGetById(id);
        }

        public List<Files> TGetList()
        {
            return _filesService.TGetList();
        }

        public void TInsert(List<Files> t)
        {
            _filesService.TInsert(t);
        }

        public void TUpdate(Files t)
        {
            _filesService.TUpdate(t);
        }
    }
}
