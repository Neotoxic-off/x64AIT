using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class leaq : BaseModel
    {
        public leaq(object? source, object? destination) :base("leaq", source, destination)
        {
            Comment = $"Load effective address of {Source} into {Destination}";
        }
    }
}
