using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class text : BaseModel
    {
        public text() : base(".text")
        {
            this.Comment = "The .text directive defines the current section as .text.";
        }
    }
}

