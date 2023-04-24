using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class bcd : BaseModel
    {
        public bcd() : base(".bcd")
        {
            this.Comment = "The .bcd directive generates a packed decimal (80-bit) value into the current section. The .bcd directive is not valid for the .bss section.";
        }
    }
}
