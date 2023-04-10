using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Tools
{
    public class Skip
    {
        public static bool CanSkip(string instruction)
        {
            if (instruction != null)
            {
                return (instruction.Length < Settings.Translator.Instruction.MinimumSize);
            }

            return (false);
        }
    }
}
