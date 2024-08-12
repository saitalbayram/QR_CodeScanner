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
    public class EfFilesDal : GenericRepository<Files>, IFilesDal
    {
        public byte[]? GetFileFromNameAndModule(string fileName, string ModuleName)
        {
            using var c = new Context();

            return [.. c.Files.Where(x => x.FileName == fileName && x.ModuleName == ModuleName).Select(x => x.ReportFile).FirstOrDefault()];
        }
    }
}
