using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IFilesDal: IGenericDal<Files>
    {
        public string GetFileFromNameAndModule(string fileName, string ModuleName);
    }
}
