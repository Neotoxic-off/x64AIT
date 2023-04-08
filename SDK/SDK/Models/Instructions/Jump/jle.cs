using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jle : BaseModel<(object? source, object? destination)>
    {
        public jle() : base("jle", (null, null))
        {
            Comment = $"Jump if less or equal";
        }
    }
}
