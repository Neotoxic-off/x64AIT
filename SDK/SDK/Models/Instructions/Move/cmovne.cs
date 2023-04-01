using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovne : BaseModel<(object? source, object? destination)>
    {
        public cmovne() : base("cmovne", (null, null))
        {

        }
    }
}
