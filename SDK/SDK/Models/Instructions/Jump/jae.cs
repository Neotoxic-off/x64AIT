using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jae : BaseModel<object?>
    {
        public jae() : base("jae", null)
        {
            Comment = $"Jump if above or equal (unsigned)";
        }
    }
}
