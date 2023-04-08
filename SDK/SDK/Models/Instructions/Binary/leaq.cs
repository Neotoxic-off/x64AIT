using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class lea : BaseModel
    {
        public lea(object? source, object? destination) :base("lea", source, destination)
        {
            Comment = $"Load effective address of {Source} into {Destination}";
        }
    }
}
