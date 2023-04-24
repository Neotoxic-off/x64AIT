using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class previous : BaseModel
    {
        public previous() : base(".previous")
        {
            this.Comment = "The .previous directive continues processing of the previous section.";
        }
    }
}

