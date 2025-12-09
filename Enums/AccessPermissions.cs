using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Enums
{
    [Flags]
    public enum AccessPermissions
    {
        None = 0,
        View = 1 << 0, // 1
        New = 1 << 1, // 2
        Edit = 1 << 2, // 4
        Delete = 1 << 3, // 8
        Print = 1 << 4  // 16
    }
}
