using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmova : BaseModel
    {
        public cmova(object? source, object? destination) :base("cmova", source, destination)
        {
            Comment = $"Move if above (unsigned)";
        }
    }
}
