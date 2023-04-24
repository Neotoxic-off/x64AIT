using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class byte4 : BaseModel
    {
        public byte4() : base(".4byte")
        {
            this.Comment = "Refer to the description of the .long directive.";
        }
    }
}

