using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class data : BaseModel
    {
        public data() : base(".data")
        {
            this.Comment = "The .data directive changes the current section to .data.";
        }
    }
}

