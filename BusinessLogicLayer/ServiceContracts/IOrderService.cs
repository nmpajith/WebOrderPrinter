using Infrastructure.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServiceContracts
{
    interface IOrderService
    {
        IEnumerable<OrderDetail> GetAllOrders();
    }
}
