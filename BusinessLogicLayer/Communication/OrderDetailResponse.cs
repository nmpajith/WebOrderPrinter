using Infrastructure.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Communication
{
    public class OrderDetailResponse : BaseResponse<OrderDetail>
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="orderDetail">Saved orderDetail.</param>
        /// <returns>Response.</returns>
        public OrderDetailResponse(OrderDetail orderDetail) : base(orderDetail)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public OrderDetailResponse(string message) : base(message)
        { }
    }
}
