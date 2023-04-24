using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class double_ : BaseModel
    {
        public double_() : base(".double")
        {
            this.Comment = "The .double directive generates a double-precision floating-point constant into the current section. The .double directive is not valid for the .bss section.";
        }
    }
}

