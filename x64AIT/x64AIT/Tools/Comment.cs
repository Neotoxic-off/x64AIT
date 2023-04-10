using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Tools
{
    public class Comment
    {
        public static bool IsComment(string instruction)
        {
            bool status = false;
            string[] comments = {
                "//",
                ";"
            };

            foreach (string comment in comments)
            {
                if (status == false)
                {
                    status = instruction.Trim().StartsWith(comment);
                }
            }

            return (status);
        }
    }
}
