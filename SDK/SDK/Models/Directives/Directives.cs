using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class Directives
    {
        private static List<BaseModel> ASMDirectives = new List<BaseModel>()
        {
            new byte2(),
            new byte4(),
            new byte8(),
            new align(),
            new ascii(),
            new bcd(),
            new bss(),
            new byte_(),
            new com(),
            new data(),
            new double_(),
            new even(),
            new ext(),
            new file_(),
            new float_(),
            new globl(),
            new group(),
            new hidden(),
            new ident(),
            new lcomm(),
            new local(),
            new long_(),
            new popsection(),
            new previous(),
            new pushsection(),
            new quad(),
            new rel(),
            new section(),
            new set(),
            new size(),
            new skip(),
            new sleb128(),
            new string_(),
            new symbolic(),
            new tbss(),
            new tcomm(),
            new tdata(),
            new text(),
            new type(),
            new uleb128(),
            new value(),
            new weak(),
            new zero()
        };

        public static int CountDirectives()
        {
            return (ASMDirectives.Count());
        }

        public static BaseModel? GetDirective(string directive)
        {
            if (IsValidDirective(directive) == true)
            {
                foreach (BaseModel? item in ASMDirectives)
                {
                    if (item.Name == directive)
                    {
                        return (item);
                    }
                }
            }

            return (null);
        }

        public static bool IsValidDirective(string directive)
        {
            foreach (BaseModel item in ASMDirectives)
            {
                if (item.Name == directive)
                {
                    return (true);
                }
            }

            return (false);
        }
    }
}
