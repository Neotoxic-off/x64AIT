using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class Instructions
    {
        private static string PlaceHolderSource = "EMPTY_SOURCE";
        private static string PlaceHolderDestination = "EMPTY_DESTINATION";
        private static List<BaseModel> ASMInstructions = new List<BaseModel>()
        {
            new Binary.add(PlaceHolderSource, PlaceHolderDestination),
            new Binary.and(PlaceHolderSource, PlaceHolderDestination),
            new Binary.imul(PlaceHolderSource, PlaceHolderDestination),
            new Binary.leaq(PlaceHolderSource, PlaceHolderDestination),
            new Binary.lea(PlaceHolderSource, PlaceHolderDestination),
            new Binary.or(PlaceHolderSource, PlaceHolderDestination),
            new Binary.sub(PlaceHolderSource, PlaceHolderDestination),
            new Binary.xor(PlaceHolderSource, PlaceHolderDestination),

            new Comparison.cmp(PlaceHolderSource, PlaceHolderDestination),
            new Comparison.test(PlaceHolderSource, PlaceHolderDestination),

            new Conditional.seta(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setae(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setb(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setbe(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.sete(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setg(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setge(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setl(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setle(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setna(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnae(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnb(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnbe(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setne(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setng(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnge(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnl(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnle(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setns(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setnz(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.sets(PlaceHolderSource, PlaceHolderDestination),
            new Conditional.setz(PlaceHolderSource, PlaceHolderDestination),

            new Data.cltq(PlaceHolderSource, PlaceHolderDestination),
            new Data.cqto(PlaceHolderSource, PlaceHolderDestination),
            new Data.cwtl(PlaceHolderSource, PlaceHolderDestination),
            new Data.mov(PlaceHolderSource, PlaceHolderDestination),
            new Data.pop(PlaceHolderSource, PlaceHolderDestination),
            new Data.push(PlaceHolderSource, PlaceHolderDestination),

            new Jump.ja(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jae(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jb(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jbe(PlaceHolderSource, PlaceHolderDestination),
            new Jump.je(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jg(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jge(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jl(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jle(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jmp(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jna(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnae(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnb(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnbe(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jne(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jng(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnge(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnl(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jns(PlaceHolderSource, PlaceHolderDestination),
            new Jump.jnz(PlaceHolderSource, PlaceHolderDestination),

            new Move.cmova(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovae(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovb(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovbe(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmove(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovg(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovge(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovl(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovle(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovna(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnae(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnb(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnbe(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovne(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovng(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnge(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnb(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnbe(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovne(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovng(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnge(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnl(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnle(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovns(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovnz(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovs(PlaceHolderSource, PlaceHolderDestination),
            new Move.cmovz(PlaceHolderSource, PlaceHolderDestination),

            new Procedure.call(PlaceHolderSource, PlaceHolderDestination),
            new Procedure.leave(PlaceHolderSource, PlaceHolderDestination),
            new Procedure.ret(PlaceHolderSource, PlaceHolderDestination),

            new Shift.sal(PlaceHolderSource, PlaceHolderDestination),
            new Shift.sar(PlaceHolderSource, PlaceHolderDestination),
            new Shift.shl(PlaceHolderSource, PlaceHolderDestination),
            new Shift.shr(PlaceHolderSource, PlaceHolderDestination),

            new Special.divq(PlaceHolderSource, PlaceHolderDestination),
            new Special.idivq(PlaceHolderSource, PlaceHolderDestination),
            new Special.imulq(PlaceHolderSource, PlaceHolderDestination),
            new Special.mulq(PlaceHolderSource, PlaceHolderDestination),

            new Unary.dec(PlaceHolderSource, PlaceHolderDestination),
            new Unary.inc(PlaceHolderSource, PlaceHolderDestination),
            new Unary.neg(PlaceHolderSource, PlaceHolderDestination),
            new Unary.not(PlaceHolderSource, PlaceHolderDestination)
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
                        return ((BaseModel?)item.Clone());
                    }
                }
            }

            return (null);
        }

        public static bool IsValidInstruction(string instruction)
        {
            foreach (SDK.Models.BaseModel item in ASMInstructions)
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
