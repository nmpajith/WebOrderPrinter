using AutoMapper;
using BusinessLogicLayer.ServiceContracts;
using Infrastructure.DataTransferObjects;
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
        private readonly IMapper _mapper;
        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<OrderDetail> GetAll()
        {
            var orders = _orderService.GetAllOrders();

            return orders;
        }

        [HttpPost]
        public IActionResult PostAsync([FromBody] CreateOrderDto createOrderDto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var orderDetail = _mapper.Map<CreateOrderDto, OrderDetail>(createOrderDto);
            DateTime dateTime = DateTime.Now;
            orderDetail.DateCreated = dateTime;
            orderDetail.DateModified = dateTime;
            var result = _orderService.SaveOrder(orderDetail);

            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(orderDetail);
        }
    }
}
