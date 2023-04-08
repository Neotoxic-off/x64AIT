using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class push: BaseModel<(object? source, object? destination)>
    {
        public push() : base("push", (null, null))
        {
            Comment = $"Push {Parameters} onto stack";
        }
    }
}
