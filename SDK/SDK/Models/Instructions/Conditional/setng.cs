using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Conditional
{
    public class setng : BaseModel<(object? source, object? destination)>
    {
        public setng() : base("setng", (0x00000000, null))
        {
            Comment = $"Set if less or equal";
        }
    }
}
