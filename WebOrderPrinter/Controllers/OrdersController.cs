using BusinessLogicLayer.ServiceContracts;
using Infrastructure.Models.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOrderPrinter.Extensions;

namespace WebOrderPrinter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public IActionResult PostAsync([FromBody] OrderDetail orderDetail)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var result = _orderService.SaveOrder(orderDetail);

            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(orderDetail);
        }
    }
}
