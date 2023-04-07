using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jb : BaseModel<object?>
    {
        public jb() : base("jb", null)
        {
            Comment = $"Jump if below (unsigned)";
        }
    }
}
