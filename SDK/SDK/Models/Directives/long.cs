using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class long : BaseModel
    {
        public long() : base(".long")
        {
            this.Comment = "The .long directive generates a long integer (32-bit, two's complement value) for each expression into the current section. Each expression must be a 32-bit value and must evaluate to an integer value. The .long directive is not valid for the .bss section.";
        }
    }
}

