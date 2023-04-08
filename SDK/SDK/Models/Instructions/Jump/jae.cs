using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jae : BaseModel
    {
        public jae(object? source, object? destination) :base("jae", source, destination)
        {
            Comment = $"Jump if above or equal (unsigned)";
        }
    }
}
