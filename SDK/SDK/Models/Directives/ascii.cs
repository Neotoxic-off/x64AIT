using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class ascii : BaseModel
    {
        public ascii() : base(".ascii")
        {
            this.Comment = "The .ascii directive places the characters in string into the object module at the current location but does not terminate the string with a null byte (\0). String must be enclosed in double quotes (\") (ASCII 0x22). The .ascii directive is not valid for the .bss section.";
        }
    }
}
