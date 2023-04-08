using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jbe : BaseModel
    {
        public jbe(object? source, object? destination) :base("jbe", source, destination)
        {
            Comment = $"Jump if below or equal (unsigned)";
        }
    }
}
