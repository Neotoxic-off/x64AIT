using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jg : BaseModel<object?>
    {
        public jg() : base("jg", null)
        {
            Comment = $"Jump if greater (signed)";
        }
    }
}
