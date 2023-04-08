using SDK;
using System.Collections;
using System.Collections.Generic;

namespace x64AIT.ViewModels
{
    public class SDKViewModel : BaseViewModel
    {
        public ArrayList Instructions { get; set; }

        public SDKViewModel()
        {
        }

        private void Load()
        {
            Instructions = new ArrayList()
            {
                SDK.Models.Instructions.Binary.add,
                SDK.Models.Instructions.Binary.and,
                SDK.Models.Instructions.Binary.imul,
                SDK.Models.Instructions.Binary.leaq,
                SDK.Models.Instructions.Binary.or,
                SDK.Models.Instructions.Binary.sub,
                SDK.Models.Instructions.Binary.xor,

                //SDK.Models.Instructions.Comparison.cmp,
                //SDK.Models.Instructions.Comparison.test,

                //SDK.Models.Instructions.Conditional.seta,
                //SDK.Models.Instructions.Conditional.setae,
                //SDK.Models.Instructions.Conditional.setb,
                //SDK.Models.Instructions.Conditional.setbe,
                //SDK.Models.Instructions.Conditional.sete,
                //SDK.Models.Instructions.Conditional.setg,
                //SDK.Models.Instructions.Conditional.setge,
                //SDK.Models.Instructions.Conditional.setl,
                //SDK.Models.Instructions.Conditional.setle,
                //SDK.Models.Instructions.Conditional.setna,
                //SDK.Models.Instructions.Conditional.setnae,
                //SDK.Models.Instructions.Conditional.setnb,
                //SDK.Models.Instructions.Conditional.setnbe,
                //SDK.Models.Instructions.Conditional.setne,
                //SDK.Models.Instructions.Conditional.setng,
                //SDK.Models.Instructions.Conditional.setnge,
                //SDK.Models.Instructions.Conditional.setnl,
                //SDK.Models.Instructions.Conditional.setnle,
                //SDK.Models.Instructions.Conditional.setns,
                //SDK.Models.Instructions.Conditional.setnz,
                //SDK.Models.Instructions.Conditional.sets,
                //SDK.Models.Instructions.Conditional.setz,

                //SDK.Models.Instructions.Data.cltq,
                //SDK.Models.Instructions.Data.cqto,
                //SDK.Models.Instructions.Data.cwtl,
                //SDK.Models.Instructions.Data.mov,
                //SDK.Models.Instructions.Data.pop,
                //SDK.Models.Instructions.Data.push,
            };
        }

        public bool IsValidInstruction(string instruction)
        {
            return (true);
        }
    }
}
