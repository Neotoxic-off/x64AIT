using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class push: BaseModel
    {
        public push(object? source, object? destination) : base("push", source, destination)
        {
            Comment = $"Push {source} onto stack";
        }
    }
}
