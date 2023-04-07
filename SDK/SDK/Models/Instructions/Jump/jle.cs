using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jle : BaseModel<object?>
    {
        public jle() : base("jle", null)
        {
            Comment = $"Jump if less or equal";
        }
    }
}
