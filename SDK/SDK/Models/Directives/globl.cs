using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class globl : BaseModel
    {
        public globl() : base(".globl")
        {
            this.Comment = "The .globl directive declares each symbol in the list to be global. Each symbol is either defined externally or defined in the input file and accessible in other files. Default bindings for the symbol are overridden. A global symbol definition in one file satisfies an undefined reference to the same global symbol in another file. Multiple definitions of a defined global symbol are not allowed. If a defined global symbol has more than one definition, an error occurs. The .globl directive only declares the symbol to be global in scope, it does not define the symbol.";
        }
    }
}

