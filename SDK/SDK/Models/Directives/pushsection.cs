using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class pushsection : BaseModel
    {
        public pushsection() : base(".pushsection")
        {
            this.Comment = "The .pushsection directive pushes the specified section onto the section stack and switches to another section.";
        }
    }
}

