using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovnae : BaseModel
    {
        public cmovnae(object? source, object? destination) :base("cmovnae", source, destination)
        {
            Comment = $"Move if below (unsigned)";
        }
    }
}
