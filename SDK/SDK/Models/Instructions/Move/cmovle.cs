using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovle : BaseModel<(object? source, object? destination)>
    {
        public cmovle() : base("cmovle", (null, null))
        {

        }
    }
}
