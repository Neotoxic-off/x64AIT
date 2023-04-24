using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class byte_ : BaseModel
    {
        public byte_() : base(".byte")
        {
            this.Comment = "The .byte directive generates initialized bytes into the current section. The .byte directive is not valid for the .bss section. Each byte must be an 8-bit value.";
        }
    }
}
