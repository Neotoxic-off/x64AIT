using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class value : BaseModel
    {
        public value() : base(".value")
        {
            this.Comment = "The .value directive generates an initialized word (16-bit, two's complement value) for each expression into the current section. Each expression must be a 16-bit integer value. The .value directive is not valid for the .bss section. ";
        }
    }
}

