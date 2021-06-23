using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Devices
{
    class DeviceDetails
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int RestId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
