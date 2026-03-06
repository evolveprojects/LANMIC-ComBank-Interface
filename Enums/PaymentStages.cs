using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Enums
{
    public enum PaymentStatus
    {
        Imported = 1,
        ValidationFailed = 2,
        Validated = 3,
        ReadyToSend = 4,
        SendFailed = 5,
        Sent = 6,
        Processing = 7,
        Completed = 8,
        Rejected = 9,
        Cancelled = 10,
        Reversed = 11
    }
}
