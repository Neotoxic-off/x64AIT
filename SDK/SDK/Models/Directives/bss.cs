using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class bss : BaseModel
    {
        public bss() : base(".bss")
        {
            this.Comment = "Define symbol in the .bss section and add integer bytes to the value of the location counter for .bss. When issued with arguments, the .bss directive does not change the current section to .bss. Integer must be positive.";
        }
    }
}
