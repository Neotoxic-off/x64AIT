using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class ret : BaseModel
    {
        public ret(object? source, object? destination) :base("ret", source, destination)
        {
            Comment = $"Pop return address from stack and jump there";
        }
    }
}
