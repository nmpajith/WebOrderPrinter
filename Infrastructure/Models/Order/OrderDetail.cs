using Infrastructure.Models.Notifications;
using Infrastructure.Models.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Order
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string CustomerOrderId { get; set; }
        public int BranchId { get; set; }
        public string Order { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Branch Branch { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IList<Notification> Notifications { get; set; }
    }
}
