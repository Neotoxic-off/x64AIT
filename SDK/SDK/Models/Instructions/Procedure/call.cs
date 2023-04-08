using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class call : BaseModel
    {
        public call(object? source, object? destination) :base("call", source, destination)
        {
            Comment = $"Push return address and jump to label/specified location";
        }
    }
}
