using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class Instructions
    {
        private static List<BaseModel> ASMInstructions = new List<BaseModel>()
        {
            new Binary.add(),
            new Binary.and(),
            new Binary.imul(),
            new Binary.leaq(),
            new Binary.lea(),
            new Binary.or(),
            new Binary.sub(),
            new Binary.xor(),

            new Comparison.cmp(),
            new Comparison.test(),

            new Conditional.seta(),
            new Conditional.setae(),
            new Conditional.setb(),
            new Conditional.setbe(),
            new Conditional.sete(),
            new Conditional.setg(),
            new Conditional.setge(),
            new Conditional.setl(),
            new Conditional.setle(),
            new Conditional.setna(),
            new Conditional.setnae(),
            new Conditional.setnb(),
            new Conditional.setnbe(),
            new Conditional.setne(),
            new Conditional.setng(),
            new Conditional.setnge(),
            new Conditional.setnl(),
            new Conditional.setnle(),
            new Conditional.setns(),
            new Conditional.setnz(),
            new Conditional.sets(),
            new Conditional.setz(),

            new Data.cltq(),
            new Data.cqto(),
            new Data.cwtl(),
            new Data.mov(),
            new Data.pop(),
            new Data.push(),

            new Jump.ja(),
            new Jump.jae(),
            new Jump.jb(),
            new Jump.jbe(),
            new Jump.je(),
            new Jump.jg(),
            new Jump.jge(),
            new Jump.jl(),
            new Jump.jle(),
            new Jump.jmp(),
            new Jump.jna(),
            new Jump.jnae(),
            new Jump.jnb(),
            new Jump.jnbe(),
            new Jump.jne(),
            new Jump.jng(),
            new Jump.jnge(),
            new Jump.jnl(),
            new Jump.jnle(),
            new Jump.jns(),
            new Jump.jz(),
            new Jump.jnz(),

            new Move.cmova(),
            new Move.cmovae(),
            new Move.cmovb(),
            new Move.cmovbe(),
            new Move.cmove(),
            new Move.cmovg(),
            new Move.cmovge(),
            new Move.cmovl(),
            new Move.cmovle(),
            new Move.cmovna(),
            new Move.cmovnae(),
            new Move.cmovnb(),
            new Move.cmovnbe(),
            new Move.cmovne(),
            new Move.cmovng(),
            new Move.cmovnge(),
            new Move.cmovnb(),
            new Move.cmovnbe(),
            new Move.cmovne(),
            new Move.cmovng(),
            new Move.cmovnge(),
            new Move.cmovnl(),
            new Move.cmovnle(),
            new Move.cmovns(),
            new Move.cmovnz(),
            new Move.cmovs(),
            new Move.cmovz(),

            new Procedure.call(),
            new Procedure.leave(),
            new Procedure.ret(),

            new Shift.sal(),
            new Shift.sar(),
            new Shift.shl(),
            new Shift.shr(),

            new Special.divq(),
            new Special.idivq(),
            new Special.imulq(),
            new Special.mulq(),

            new Unary.dec(),
            new Unary.inc(),
            new Unary.neg(),
            new Unary.not()
        };

        public static int CountInstructions()
        {
            return (ASMInstructions.Count());
        }

        public static BaseModel? GetInstruction(string instruction)
        {
            if (IsValidInstruction(instruction) == true)
            {
                foreach (BaseModel? item in ASMInstructions)
                {
                    if (item.Name == instruction)
                    {
                        return (item.Clone());
                    }
                }
            }

            return (null);
        }

        public static bool IsValidInstruction(string instruction)
        {
            foreach (BaseModel item in ASMInstructions)
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
