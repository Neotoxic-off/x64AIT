using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class weak : BaseModel
    {
        public weak() : base(".weak")
        {
            this.Comment = "The .weak directive declares each symbol in the argument list to be defined either externally or in the input file and accessible to other files. Default bindings of the symbol are overridden by the .weak directive. A weak symbol definition in one file satisfies an undefined reference to a global symbol of the same name in another file. Unresolved weak symbols have a default value of zero. The link editor does not resolve these symbols. If a weak symbol has the same name as a defined global symbol, the weak symbol is ignored and no error results. The .weak directive does not define the symbol.";
        }
    }
}

