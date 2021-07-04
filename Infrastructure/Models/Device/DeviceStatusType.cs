using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Device
{
    public class DeviceStatusType
    {
        public int Id { get; set; }
        public EDeviceStatusTypeNames DeviceStatusTypeName { get; set; }
        public DeviceStatus DeviceStatus { get; set; }
    }
}
