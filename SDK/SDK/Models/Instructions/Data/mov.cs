using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Data
{
    public class mov: BaseModel
    {
        public mov(object? source, object? destination) : base("mov", source, destination)
        {
            Comment = $"Move {source} to {destination}";
        }
    }
}
