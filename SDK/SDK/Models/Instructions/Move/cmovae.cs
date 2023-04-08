using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovae : BaseModel
    {
        public cmovae(object? source, object? destination) :base("cmovae", source, destination)
        {
            Comment = $"Move if above or equal (unsigned)";
        }
    }
}
