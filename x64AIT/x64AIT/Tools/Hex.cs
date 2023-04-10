using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Tools
{
    public class Hex
    {
        public static bool IsHex(string instruction)
        {
            string characters = "0123456789ABCDEF";

            if (instruction != null)
            {
                foreach (char c in instruction)
                {
                    if (characters.Contains(c) == false)
                    {
                        return (false);
                    }
                }
                return (true);
            }
            return (false);
        }
    }
}
