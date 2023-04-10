using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class pop: BaseModel
    {
        public pop(object? source, object? destination) :base("pop", source, destination)
        {
            Comment = $"Pop top of stack into {source}";
        }
    }
}
