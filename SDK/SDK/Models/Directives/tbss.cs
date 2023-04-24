using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class tbss : BaseModel
    {
        public tbss() : base(".tbss")
        {
            this.Comment = "The .tbss directive changes the current section to .tbss. The .tbss section contains uninitialized TLS data objects that will be initialized to zero by the runtime linker.";
        }
    }
}

