using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovs : BaseModel
    {
        public cmovs(object? source, object? destination) :base("cmovs", source, destination)
        {
            Comment = $"Move if negative";
        }
    }
}
