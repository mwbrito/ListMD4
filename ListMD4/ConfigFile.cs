using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMD4
{
    public class ConfigFile
    {
        public string cacheAmbiente { get; set; }
        public List<string> Ambientes { get; set; }
        public List<string> Endpoints { get; set; }
    }
}
