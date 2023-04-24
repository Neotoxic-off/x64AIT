using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class string : BaseModel
    {
        public string() : base(".string")
        {
            this.Comment = "The .string directive places the characters in string into the object module at the current location and terminates the string with a null byte (\0). String must be enclosed in double quotes (") (ASCII 0x22). The .string directive is not valid for the .bss section.";
        }
    }
}

