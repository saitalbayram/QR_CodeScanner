using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PosetPaket
    {
        public int ID { get; set; }
        public string? PosetBarkod { get; set; }
        public string? PaketBarkod { get; set; }
        public AppUser? Users { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool SilinecekSatir { get; set; }
    }
}
