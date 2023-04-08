using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class js : BaseModel
    {
        public js(object? source, object? destination) :base("js", source, destination)
        {
            Comment = $"Jump if negative";
        }
    }
}
