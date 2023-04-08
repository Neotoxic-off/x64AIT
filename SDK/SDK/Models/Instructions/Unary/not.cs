using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class not : BaseModel
    {
        public not(object? source, object? destination) :base("not", source, destination)
        {
            Comment = $"Bitwise complement";
        }
    }
}
