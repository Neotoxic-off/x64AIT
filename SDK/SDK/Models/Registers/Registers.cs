using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Registers
{
    public class Registers
    {
        private static List<BaseModel> ASMRegisters = new List<BaseModel>()
        {
            new x8.al(),
            new x8.bl(),
            new x8.bpl(),
            new x8.cl(),
            new x8.dil(),
            new x8.dl(),
            new x8.r10b(),
            new x8.r11b(),
            new x8.r12b(),
            new x8.r13b(),
            new x8.r14b(),
            new x8.r15b(),
            new x8.r8b(),
            new x8.r9b(),
            new x8.sil(),
            new x8.spl(),

            new x16.ax(),
            new x16.bp(),
            new x16.bx(),
            new x16.cx(),
            new x16.di(),
            new x16.dx(),
            new x16.r10w(),
            new x16.r11w(),
            new x16.r12w(),
            new x16.r13w(),
            new x16.r14w(),
            new x16.r15w(),
            new x16.r8w(),
            new x16.r9w(),
            new x16.si(),
            new x16.sp(),

            new x32.eax(),
            new x32.ebp(),
            new x32.ebx(),
            new x32.ecx(),
            new x32.edi(),
            new x32.edx(),
            new x32.esi(),
            new x32.esp(),
            new x32.r10d(),
            new x32.r11d(),
            new x32.r12d(),
            new x32.r13d(),
            new x32.r14d(),
            new x32.r15d(),
            new x32.r8d(),
            new x32.r9d(),

            new x64.r10(),
            new x64.r11(),
            new x64.r12(),
            new x64.r13(),
            new x64.r14(),
            new x64.r15(),
            new x64.r8(),
            new x64.r9(),
            new x64.rax(),
            new x64.rbp(),
            new x64.rbx(),
            new x64.rcx(),
            new x64.rdi(),
            new x64.rdx(),
            new x64.rsi(),
            new x64.rsp()
        };

        public static int CountRegisters()
        {
            return (ASMRegisters.Count());
        }

        public static BaseModel? GetRegister(string register)
        {
            if (IsValidRegister(register) == true)
            {
                foreach (BaseModel? item in ASMRegisters)
                {
                    if (item.Name == register)
                    {
                        return (item);
                    }
                }
            }

            return (null);
        }

        public static bool IsValidRegister(string register)
        {
            foreach (BaseModel item in ASMRegisters)
            {
                if (item.Name == register)
                {
                    return (true);
                }
            }

            return (false);
        }

        public static int GetRegisterSize(string register)
        {
            BaseModel? result = GetRegister(register);

            if (result != null)
            {
                return (result.Size);
            }

            return (0);
        }
    }
}
