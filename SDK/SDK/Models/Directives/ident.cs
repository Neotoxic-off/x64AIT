using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class ident : BaseModel
    {
        public ident() : base(".ident")
        {
            this.Comment = "The .ident directive creates an entry in the .comment section containing string. String is any sequence of characters, not including the double quote ("). To include the double quote character within a string, precede the double quote character with a backslash (\) (ASCII 0x5C).";
        }
    }
}

