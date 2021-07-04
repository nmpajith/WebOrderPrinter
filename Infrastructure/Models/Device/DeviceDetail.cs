using Infrastructure.Models.Restaurant;
using Infrastructure.Models.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Device
{
    public class DeviceDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Branch Branch { get; set; }
        public DeviceStatus DeviceStatus { get; set; }
        public IList<Notification> Notifications { get; set; }
    }
}
