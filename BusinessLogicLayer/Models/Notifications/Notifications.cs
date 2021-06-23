using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Notifications
{
    class Notifications
    {
        public int Id { get; set; }
        public int NotificationTypeId { get; set; }
        public int RestId { get; set; }
        public int BranchId { get; set; }
        public int DeviceId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
