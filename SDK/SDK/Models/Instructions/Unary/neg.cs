using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class neg : BaseModel
    {
        public neg(object? source, object? destination) :base("neg", source, destination)
        {
            Comment = $"Arithmetic negation";
        }
    }
}
