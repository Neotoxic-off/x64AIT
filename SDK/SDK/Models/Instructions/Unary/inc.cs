﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions.Unary
{
    public class inc : BaseModel<UInt64>
    {
        public inc() : base("inc", 0x00000000)
        {

        }
    }
}
