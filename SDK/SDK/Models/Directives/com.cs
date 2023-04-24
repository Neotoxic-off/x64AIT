using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class com : BaseModel
    {
        public com() : base(".com")
        {
            this.Comment = "The .comm directive allocates storage in the data section. The storage is referenced by the identifier name. Size is measured in bytes and must be a positive integer. Name cannot be predefined. Alignment is optional. If alignment is specified, the address of name is aligned to a multiple of alignment.";
        }
    }
}

