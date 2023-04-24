using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class lcomm : BaseModel
    {
        public lcomm() : base(".lcomm")
        {
            this.Comment = "The .lcomm directive allocates storage in the .bss section. The storage is referenced by the symbol name, and has a size of size bytes. Name cannot be predefined, and size must be a positive integer. If alignment is specified, the address of name is aligned to a multiple of alignment bytes. If alignment is not specified, the default alignment is 4 bytes.";
        }
    }
}

