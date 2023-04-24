using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class tdata : BaseModel
    {
        public tdata() : base(".tdata")
        {
            this.Comment = "The .tdata directive changes the current section to .tdata. The .tdata section contains the initialization image for initialized TLS data objects.";
        }
    }
}

