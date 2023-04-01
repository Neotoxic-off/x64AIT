using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmove : BaseModel<(object? source, object? destination)>
    {
        public cmove() : base("cmove", (null, null))
        {

        }
    }
}
