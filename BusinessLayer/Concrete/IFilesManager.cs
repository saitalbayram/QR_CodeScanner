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
        IFilesDal _filesDal = filesDal;

        public string GetFileFromNameAndModule(string fileName, string ModuleName)
        {
            return _filesDal.GetFileFromNameAndModule(fileName, ModuleName);
        }

        public void TDelete(Files t)
        {
            _filesDal.TDelete(t);
        }

        public Files? TGetById(int? id)
        {
            return _filesDal.TGetById(id);
        }

        public List<Files> TGetList()
        {
            return _filesDal.TGetList();
        }

        public void TInsert(Files t)
        {
            _filesDal.TInsert(t);
        }

        public void TUpdate(Files t)
        {
            _filesDal.TUpdate(t);
        }
    }
}
