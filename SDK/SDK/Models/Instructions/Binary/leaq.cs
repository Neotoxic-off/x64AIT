using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Binary
{
    public class leaq : BaseModel<(object? source, object? destination)>
    {
        public leaq() : base("leaq", (null, null))
        {

        }
    }
}
