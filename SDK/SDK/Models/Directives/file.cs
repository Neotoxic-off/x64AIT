using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class file_ : BaseModel
    {
        public file_() : base(".file")
        {
            this.Comment = "The .file directive creates a symbol table entry where string is the symbol name and STT_FILE is the symbol table type. String specifies the name of the source file associated with the object file.";
        }
    }
}

