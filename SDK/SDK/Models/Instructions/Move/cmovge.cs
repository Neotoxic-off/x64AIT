using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovge : BaseModel
    {
        public cmovge(object? source, object? destination) :base("cmovge", source, destination)
        {
            Comment = $"Move if greater or equal (signed)";
        }
    }
}
