using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jge : BaseModel<(object? source, object? destination)>
    {
        public jge() : base("jge", (null, null))
        {
            Comment = $"Jump if greater or equal (signed)";
        }
    }
}
