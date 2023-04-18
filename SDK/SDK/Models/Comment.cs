using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models
{
    public class Comment
    {
        public string? Start { get; set; }
        public string? Between { get; set; }
        public string? End { get; set; }
        public object? Source { get; set; }
        public object? Destination { get; set; }
        public string? Render { get; set; }
    }
}
