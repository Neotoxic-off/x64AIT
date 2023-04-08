using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class pop: BaseModel<(object? source, object? destination)>
    {
        public pop() : base("pop", (null, null))
        {
            Comment = $"Pop top of stack into {Parameters}";
        }
    }
}
