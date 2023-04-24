using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class quad : BaseModel
    {
        public quad() : base(".quad")
        {
            this.Comment = "The .quad directive generates an initialized word (64-bit, two's complement value) for each expression into the current section. Each expression must be a 64-bit value, and must evaluate to an integer value. The .quad directive is not valid for the .bss section.";
        }
    }
}

