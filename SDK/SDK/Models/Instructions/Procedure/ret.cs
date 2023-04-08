using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Procedure
{
    public class ret : BaseModel<(object? source, object? destination)>
    {
        public ret() : base("ret", (null, null))
        {
            Comment = $"Pop return address from stack and jump there";
        }
    }
}
