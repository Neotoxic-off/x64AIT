using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmova : BaseModel<(object? source, object? destination)>
    {
        public cmova() : base("cmova", (null, null))
        {

        }
    }
}
