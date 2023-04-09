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
            new Binary.add(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.and(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.imul(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.leaq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.lea(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.or(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.sub(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Binary.xor(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Comparison.cmp(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Comparison.test(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Conditional.seta(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.sete(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setg(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setle(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setna(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setne(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setng(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnle(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setns(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setnz(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.sets(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Conditional.setz(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Data.cltq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Data.cqto(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Data.cwtl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Data.mov(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Data.pop(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Data.push(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Jump.ja(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.je(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jg(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jle(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jmp(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jna(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jne(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jng(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jns(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Jump.jnz(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Move.cmova(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmove(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovg(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovle(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovna(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnae(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovne(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovng(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnb(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnbe(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovne(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovng(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnge(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnle(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovns(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovnz(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovs(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Move.cmovz(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Procedure.call(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Procedure.leave(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Procedure.ret(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Shift.sal(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Shift.sar(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Shift.shl(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Shift.shr(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Special.divq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Special.idivq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Special.imulq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Special.mulq(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),

            new Unary.dec(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Unary.inc(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Unary.neg(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination),
            new Unary.not(BaseModel.PlaceHolderSource, BaseModel.PlaceHolderDestination)
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
