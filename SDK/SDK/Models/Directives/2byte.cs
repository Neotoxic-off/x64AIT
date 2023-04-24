using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class byte2 : BaseModel
    {
        public byte2() : base(".2byte")
        {
            this.Comment = "Refer to the description of the .value directive.";
        }
    }
}

