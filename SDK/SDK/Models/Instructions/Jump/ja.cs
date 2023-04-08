using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class ja : BaseModel<(object? source, object? destination)>
    {
        public ja() : base("ja", (null, null))
        {
            Comment = $"Jump if above (unsigned)";
        }
    }
}
