using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class local : BaseModel
    {
        public local() : base(".local")
        {
            this.Comment = "The .local directive declares each symbol in the list to be local. Each symbol is defined in the input file and not accessible to other files. Default bindings for the symbols are overridden. Symbols declared with the .local directive take precedence over weak and global symbols. Because local symbols are not accessible to other files, local symbols of the same name may exist in multiple files. The .local directive only declares the symbol to be local in scope, it does not define the symbol.";
        }
    }
}

