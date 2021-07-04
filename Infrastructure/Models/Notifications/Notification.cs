using Infrastructure.Models.Device;
using Infrastructure.Models.Order;
using Infrastructure.Models.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Notifications
{
    public class Notification
    {
        public int Id { get; set; }
        public int NotificationTypeId { get; set; }
        public int BranchId { get; set; }
        public int DeviceDetailId { get; set; }
        public int OrderDetailId { get; set; }
        public NotificationType NotificationType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Branch Branch { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public DeviceDetail DeviceDetail { get; set; }
    }
}
