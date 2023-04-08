using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class js : BaseModel<(object? source, object? destination)>
    {
        public js() : base("js", (null, null))
        {
            Comment = $"Jump if negative";
        }
    }
}
