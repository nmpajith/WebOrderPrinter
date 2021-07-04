using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Order
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int OrderStatusTypeId { get; set; }
        public int OrderDetailId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
