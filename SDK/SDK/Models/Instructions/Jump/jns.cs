using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jns : BaseModel<object?>
    {
        public jns() : base("jns", null)
        {
            Comment = $"Jump if nonnegative";
        }
    }
}
