using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class tcomm : BaseModel
    {
        public tcomm() : base(".tcomm")
        {
            this.Comment = "The .tcomm directive defines a TLS common block.";
        }
    }
}

