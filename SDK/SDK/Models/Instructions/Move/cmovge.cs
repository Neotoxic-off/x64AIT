using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovge : BaseModel<(object? source, object? destination)>
    {
        public cmovge() : base("cmovge", (null, null))
        {

        }
    }
}
