﻿using BusinessLogicLayer.Communication;
using Infrastructure.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServiceContracts
{
    public interface IOrderService
    {
        IEnumerable<OrderDetail> GetAllOrders();
        OrderDetailResponse SaveOrder(OrderDetail orderDetail);
    }
}
