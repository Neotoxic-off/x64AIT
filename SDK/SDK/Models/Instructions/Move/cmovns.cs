using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovns : BaseModel<(object? source, object? destination)>
    {
        public cmovns() : base("cmovns", (null, null))
        {

        }
    }
}
