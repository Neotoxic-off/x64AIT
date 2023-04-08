﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jnz : BaseModel
    {
        public jnz(object? source, object? destination) :base("jnz", source, destination)
        {
            Comment = $"Jump if not equal/nonzero";
        }
    }
}
