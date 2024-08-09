using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Files
    {
        public int ID { get; set; }
        public string? FileName { get; set; }
        public string? ModuleNama { get; set; }
        public byte[]? ReportFile { get; set; }
    }
}
