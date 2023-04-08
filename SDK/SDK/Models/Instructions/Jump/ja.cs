using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class ja : BaseModel
    {
        public ja(object? source, object? destination) :base("ja", source, destination)
        {
            Comment = $"Jump if above (unsigned)";
        }
    }
}
