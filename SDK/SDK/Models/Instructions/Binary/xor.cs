using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class xor : BaseModel<(object? source, object? destination)>
    {
        public xor() : base("xor", (null, null))
        {

        }
    }
}
