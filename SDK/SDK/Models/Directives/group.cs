using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class group : BaseModel
    {
        public group() : base(".group")
        {
            this.Comment = "The .group directive adds section to a COMDAT group.";
        }
    }
}

