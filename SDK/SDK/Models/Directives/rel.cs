using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class rel : BaseModel
    {
        public rel() : base(".rel")
        {
            this.Comment = "The .rel directive generates the specified relocation entry type for the specified symbol. The .lit directive supports TLS (thread-local storage).";
        }
    }
}

