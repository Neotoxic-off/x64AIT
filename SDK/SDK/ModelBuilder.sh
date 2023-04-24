#!/bin/bash

name=$1
comment=$2
template="using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class $name : BaseModel
    {
        public $name() : base(\".$name\")
        {
            this.Comment = \"$2\";
        }
    }
}
"

echo "$template" >> Models/Directives/$1.cs