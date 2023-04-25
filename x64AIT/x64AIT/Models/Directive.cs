using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Models
{
    public class Directive
    {
        public enum States
        {
            Valid,
            Invalid
        }

        public string? Value { get; set; }
        public string? Comment { get; set; }
        public List<object?> Parameters { get; set; }
        public int Index { get; set; }
        public States State { get; set; }
    }
}
