using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jbe : BaseModel<(object? source, object? destination)>
    {
        public jbe() : base("jbe", (null, null))
        {
            Comment = $"Jump if below or equal (unsigned)";
        }
    }
}
