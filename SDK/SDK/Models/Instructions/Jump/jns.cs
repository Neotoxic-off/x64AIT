﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class jns : BaseModel
    {
        public jns(object? source, object? destination) :base("jns", source, destination)
        {
            Comment = $"Jump if nonnegative";
        }
    }
}
