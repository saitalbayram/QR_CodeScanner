using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Concrete
{
    public class RegistrySettings
    {
        public string? ServerName { get; set; }
        public string? Database { get; set; }
        public string? UserName { get; set; }
        public string? Pass { get; set; }
        public string? Authentication { get; set; }
    }
}
