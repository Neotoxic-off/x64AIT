using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jng : BaseModel
    {
        public jng(object? source, object? destination) :base("jng", source, destination)
        {
            Comment = $"Jump if less or equal";
        }
    }
}
