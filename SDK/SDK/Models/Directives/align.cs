using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Models.Directives
{
    public class align : BaseModel
    {
        public align() : base(".align")
        {
            this.Comment = "The .align directive causes the next data generated to be aligned modulo integer bytes. Integer must be a positive integer expression and must be a power of 2. If specified, pad is an integer byte value used for padding. The default value of pad for the text section is 0x90 (nop); for other sections, the default value of pad is zero (0).";
        }
    }
}
