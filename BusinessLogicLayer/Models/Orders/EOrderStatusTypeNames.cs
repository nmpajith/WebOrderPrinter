using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Orders
{
    public enum EOrderStatusTypeNames
    {
        OrderValidationFailed = 1,
        OrderValidated = 2,
        DeviceOffline = 3,
        SentToDevice = 4,
        ReceivedByTheDevice = 5,
        PrintingFailed = 6,
        PrintedSuccessfully
    }
}
