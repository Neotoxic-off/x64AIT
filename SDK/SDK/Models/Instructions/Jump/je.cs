using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class je : BaseModel<object?>
    {
        public je() : base("je", null)
        {
            Comment = $"Jump if equal/zero";
        }
    }
}
