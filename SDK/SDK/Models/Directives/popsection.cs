using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class popsection : BaseModel
    {
        public popsection() : base(".popsection")
        {
            this.Comment = "The .popsection directive pops the top of the section stack and continues processing of the popped section.";
        }
    }
}

