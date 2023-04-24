using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class byte8 : BaseModel
    {
        public byte8() : base(".8byte")
        {
            this.Comment = "Refer to the description of the .quad directive.";
        }
    }
}

