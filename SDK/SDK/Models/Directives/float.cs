using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class float_ : BaseModel
    {
        public float_() : base(".float")
        {
            this.Comment = "The .float directive generates a single-precision floating-point constant into the current section. The .float directive is not valid in the .bss section.";
        }
    }
}

