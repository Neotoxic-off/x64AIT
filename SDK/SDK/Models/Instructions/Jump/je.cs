using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class je : BaseModel
    {
        public je(object? source, object? destination) :base("je", source, destination)
        {
            Comment = $"Jump if equal/zero";
        }
    }
}
