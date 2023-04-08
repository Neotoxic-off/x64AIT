using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Settings
{
    public class Configuration
    {
        public System.Version? Version { get; set; }
        public int OS { get; set; }
        public string[]? Parameters { get; set; }
    }
}
