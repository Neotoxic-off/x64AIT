using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class hidden : BaseModel
    {
        public hidden() : base(".hidden")
        {
            this.Comment = "The .hidden directive declares each symbol in the list to have hidden linker scoping. All references to symbol within a dynamic module bind to the definition within that module. Symbol is not visible outside of the module.";
        }
    }
}

