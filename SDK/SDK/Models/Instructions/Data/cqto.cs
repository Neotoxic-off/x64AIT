using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class cqto : BaseModel
    {
        public cqto(object? source, object? destination) :base("cqto", source, destination)
        {
            Comment = $"Convert quadword in %rax to octoword in %rdx:%rax";
        }
    }
}
