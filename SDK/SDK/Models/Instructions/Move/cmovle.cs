using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovle : BaseModel
    {
        public cmovle(object? source, object? destination) :base("cmovle", source, destination)
        {
            Comment = $"Move if less or equal";
        }
    }
}
