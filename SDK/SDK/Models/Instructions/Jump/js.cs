﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Jump
{
    public class js : BaseModel<object?>
    {
        public js() : base("js", null)
        {
            Comment = $"Jump if negative";
        }
    }
}