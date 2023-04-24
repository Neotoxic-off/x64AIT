using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class ext : BaseModel
    {
        public ext() : base(".ext")
        {
            this.Comment = "The .ext directive generates an 80387 80-bit floating point constant for each expression into the current section. The .ext directive is not valid for the .bss section. ";
        }
    }
}

