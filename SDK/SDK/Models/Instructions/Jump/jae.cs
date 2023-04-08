using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jae : BaseModel<(object? source, object? destination)>
    {
        public jae() : base("jae", (null, null))
        {
            Comment = $"Jump if above or equal (unsigned)";
        }
    }
}
