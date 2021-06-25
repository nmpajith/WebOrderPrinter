using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Devices
{
    public class DeviceStatus
    {
        public int Id { get; set; }
        public int DeviceStatusTypeId { get; set; }
        public int DeviceDetailTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public DeviceDetail DeviceDetail { get; set; }
        public DeviceStatusType DeviceStatusTypes { get; set; }



    }
}
