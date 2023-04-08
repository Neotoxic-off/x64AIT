using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jna : BaseModel
    {
        public jna(object? source, object? destination) :base("jna", source, destination)
        {
            Comment = $"Jump if below or equal (unsigned)";
        }
    }
}
