﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jz : BaseModel<(object? source, object? destination)>
    {
        public jz() : base("jz", (null, null))
        {
            Comment = $"Jump if equal/zero";
        }
    }
}
