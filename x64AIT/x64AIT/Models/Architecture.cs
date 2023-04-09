using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Models
{
    public class Architecture
    {
        public SDK.Models.Instructions.BaseModel Instruction { get; set; }
        public int InstructionIndex { get; set; }
    }
}
