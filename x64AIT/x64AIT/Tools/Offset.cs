using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Tools
{
    public class Offset
    {
        public static bool IsOffset(string instruction)
        {
            if (instruction != null)
            {
                if (instruction.Length == Settings.Translator.Instruction.OffsetSize)
                {
                    return (Hex.IsHex(instruction));
                }
            }

            return (false);
        }
    }
}
