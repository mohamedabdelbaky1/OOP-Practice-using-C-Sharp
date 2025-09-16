using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    [Flags]
    internal enum Permissions
    {
        None = 0,
        Read = 1 ,   // 0001
        Write = 2 ,  // 0010
        Delete = 4 , // 0100
        Execute = 8  // 1000
    }
}
