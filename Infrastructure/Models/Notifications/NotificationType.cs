using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Notifications
{
    public class NotificationType
    {
        public int Id { get; set; }
        public ENotificationTypeNames NotificationTypeName { get; set; }
        public string Message { get; set; }
        public Notification Notification { get; set; }
    }
}
