﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Instructions
{
    public class cwtl: BaseModel<object?>
    {
        public cwtl() : base("cwtl", null)
        {
            Comment = $"Convert word in %ax to doubleword in %eax (sign-extended)";
        }
    }
}
