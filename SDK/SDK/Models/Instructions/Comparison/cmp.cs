using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Comparison
{
    public class cmp : BaseModel<(object? item1, object? item2)>
    {
        public cmp() : base("cmp", (null, null))
        {

        }
    }
}
