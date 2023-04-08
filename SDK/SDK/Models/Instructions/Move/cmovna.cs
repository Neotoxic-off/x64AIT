using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovna : BaseModel
    {
        public cmovna(object? source, object? destination) :base("cmovna", source, destination)
        {
            Comment = $"Move if below (unsigned)";
        }
    }
}
