using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cwtl: BaseModel
    {
        public cwtl(object? source, object? destination) :base("cwtl", source, destination)
        {
            Comment = $"Convert word in %ax to doubleword in %eax (sign-extended)";
        }
    }
}
