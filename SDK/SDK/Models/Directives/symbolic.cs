using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class symbolic : BaseModel
    {
        public symbolic() : base(".symbolic")
        {
            this.Comment = "The .symbolic directive declares each symbol in the list to havesymbolic linker scoping. All references to symbol within a dynamic module bind to the definition within that module. Outside of the module, symbol is treated as global.";
        }
    }
}

