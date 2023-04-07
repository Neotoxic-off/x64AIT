using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Move
{
    public class cmovz : BaseModel<(object? source, object? destination)>
    {
        public cmovz() : base("cmovz", (null, null))
        {
            Comment = $"Move if equal/zero";
        }
    }
}
