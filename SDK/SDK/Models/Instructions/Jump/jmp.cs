﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jmp : BaseModel<object?>
    {
        public jmp() : base("jmp", null)
        {
            Comment = $"Jump to label/specified location";
        }
    }
}