using Infrastructure.Models.Device;
using Infrastructure.Models.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Restaurant
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Restaurant Restaurant { get; set; }
        public IList<Contact> Contacts { get; set; } = new List<Contact>();
        public Address Address { get; set; }
        public IList<Notification> Notifications { get; set; }
        public IList<DeviceDetail> DeviceDetails { get; set; }
    }
}
