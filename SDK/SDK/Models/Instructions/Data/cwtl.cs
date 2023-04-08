using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cwtl: BaseModel<(object? source, object? destination)>
    {
        public cwtl() : base("cwtl", (null, null))
        {
            Comment = $"Convert word in %ax to doubleword in %eax (sign-extended)";
        }
    }
}
