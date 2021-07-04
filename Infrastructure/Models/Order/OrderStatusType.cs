using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Order
{
    public class OrderStatusType
    {
        public int Id { get; set; }
        public EOrderStatusTypeNames OrderStatusTypeName { get; set; }
        public string Message { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
