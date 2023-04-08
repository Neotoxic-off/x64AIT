using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class call : BaseModel<(object? source, object? destination)>
    {
        public call() : base("call", (null, null))
        {
            Comment = $"Push return address and jump to label/specified location";
        }
    }
}
