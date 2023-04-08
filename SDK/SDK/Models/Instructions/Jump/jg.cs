using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jg : BaseModel<(object? source, object? destination)>
    {
        public jg() : base("jg", (null, null))
        {
            Comment = $"Jump if greater (signed)";
        }
    }
}
