using SDK;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Windows;

namespace x64AIT.ViewModels
{
    public class SDKViewModel : BaseViewModel
    {
        public List<dynamic> Instructions { get; set; }

        public SDKViewModel()
        {
            Load();
        }

        private void Load()
        {
            Instructions = new List<dynamic>()
            {
                new SDK.Models.Instructions.Binary.add(),
                new SDK.Models.Instructions.Binary.and(),
                new SDK.Models.Instructions.Binary.imul(),
                new SDK.Models.Instructions.Binary.leaq(),
                new SDK.Models.Instructions.Binary.or(),
                new SDK.Models.Instructions.Binary.sub(),
                new SDK.Models.Instructions.Binary.xor(),

                new SDK.Models.Instructions.Comparison.cmp(),
                new SDK.Models.Instructions.Comparison.test(),

                new SDK.Models.Instructions.Conditional.seta(),
                new SDK.Models.Instructions.Conditional.setae(),
                new SDK.Models.Instructions.Conditional.setb(),
                new SDK.Models.Instructions.Conditional.setbe(),
                new SDK.Models.Instructions.Conditional.sete(),
                new SDK.Models.Instructions.Conditional.setg(),
                new SDK.Models.Instructions.Conditional.setge(),
                new SDK.Models.Instructions.Conditional.setl(),
                new SDK.Models.Instructions.Conditional.setle(),
                new SDK.Models.Instructions.Conditional.setna(),
                new SDK.Models.Instructions.Conditional.setnae(),
                new SDK.Models.Instructions.Conditional.setnb(),
                new SDK.Models.Instructions.Conditional.setnbe(),
                new SDK.Models.Instructions.Conditional.setne(),
                new SDK.Models.Instructions.Conditional.setng(),
                new SDK.Models.Instructions.Conditional.setnge(),
                new SDK.Models.Instructions.Conditional.setnl(),
                new SDK.Models.Instructions.Conditional.setnle(),
                new SDK.Models.Instructions.Conditional.setns(),
                new SDK.Models.Instructions.Conditional.setnz(),
                new SDK.Models.Instructions.Conditional.sets(),
                new SDK.Models.Instructions.Conditional.setz(),

                new SDK.Models.Instructions.Data.cltq(),
                new SDK.Models.Instructions.Data.cqto(),
                new SDK.Models.Instructions.Data.cwtl(),
                new SDK.Models.Instructions.Data.mov(),
                new SDK.Models.Instructions.Data.pop(),
                new SDK.Models.Instructions.Data.push(),

                new SDK.Models.Instructions.Jump.ja(),
                new SDK.Models.Instructions.Jump.jae(),
                new SDK.Models.Instructions.Jump.jb(),
                new SDK.Models.Instructions.Jump.jbe(),
                new SDK.Models.Instructions.Jump.je(),
                new SDK.Models.Instructions.Jump.jg(),
                new SDK.Models.Instructions.Jump.jge(),
                new SDK.Models.Instructions.Jump.jl(),
                new SDK.Models.Instructions.Jump.jle(),
                new SDK.Models.Instructions.Jump.jmp(),
                new SDK.Models.Instructions.Jump.jna(),
                new SDK.Models.Instructions.Jump.jnae(),
                new SDK.Models.Instructions.Jump.jnb(),
                new SDK.Models.Instructions.Jump.jnbe(),
                new SDK.Models.Instructions.Jump.jne(),
                new SDK.Models.Instructions.Jump.jng(),
                new SDK.Models.Instructions.Jump.jnge(),
                new SDK.Models.Instructions.Jump.jnl(),
                new SDK.Models.Instructions.Jump.jns(),
                new SDK.Models.Instructions.Jump.jnz(),

                new SDK.Models.Instructions.Move.cmova(),
                new SDK.Models.Instructions.Move.cmovae(),
                new SDK.Models.Instructions.Move.cmovb(),
                new SDK.Models.Instructions.Move.cmovbe(),
                new SDK.Models.Instructions.Move.cmove(),
                new SDK.Models.Instructions.Move.cmovg(),
                new SDK.Models.Instructions.Move.cmovge(),
                new SDK.Models.Instructions.Move.cmovl(),
                new SDK.Models.Instructions.Move.cmovle(),
                new SDK.Models.Instructions.Move.cmovna(),
                new SDK.Models.Instructions.Move.cmovnae(),
                new SDK.Models.Instructions.Move.cmovnb(),
                new SDK.Models.Instructions.Move.cmovnbe(),
                new SDK.Models.Instructions.Move.cmovne(),
                new SDK.Models.Instructions.Move.cmovng(),
                new SDK.Models.Instructions.Move.cmovnge(),
                new SDK.Models.Instructions.Move.cmovnb(),
                new SDK.Models.Instructions.Move.cmovnbe(),
                new SDK.Models.Instructions.Move.cmovne(),
                new SDK.Models.Instructions.Move.cmovng(),
                new SDK.Models.Instructions.Move.cmovnge(),
                new SDK.Models.Instructions.Move.cmovnl(),
                new SDK.Models.Instructions.Move.cmovnle(),
                new SDK.Models.Instructions.Move.cmovns(),
                new SDK.Models.Instructions.Move.cmovnz(),
                new SDK.Models.Instructions.Move.cmovs(),
                new SDK.Models.Instructions.Move.cmovz(),

                new SDK.Models.Instructions.Procedure.call(),
                new SDK.Models.Instructions.Procedure.leave(),
                new SDK.Models.Instructions.Procedure.ret(),

                new SDK.Models.Instructions.Shift.sal(),
                new SDK.Models.Instructions.Shift.sar(),
                new SDK.Models.Instructions.Shift.shl(),
                new SDK.Models.Instructions.Shift.shr(),

                new SDK.Models.Instructions.Special.divq(),
                new SDK.Models.Instructions.Special.idivq(),
                new SDK.Models.Instructions.Special.imulq(),
                new SDK.Models.Instructions.Special.mulq(),

                new SDK.Models.Instructions.Unary.dec(),
                new SDK.Models.Instructions.Unary.inc(),
                new SDK.Models.Instructions.Unary.neg(),
                new SDK.Models.Instructions.Unary.not()
            };
        }

        public dynamic GetInstruction(string instruction)
        {
            foreach (dynamic item in Instructions)
            {
                if (item.Name == instruction)
                {
                    return (item);
                }
            }

            return (null);
        }

        public bool IsValidInstruction(string instruction)
        {
            foreach (dynamic item in Instructions)
            {
                if (item.Name == instruction)
                {
                    return (true);
                }
            }

            return (false);
        }
    }
}
