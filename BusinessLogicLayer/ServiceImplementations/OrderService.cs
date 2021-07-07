using System;
using System.Collections.Generic;
using DataAccessLayer.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models.Order;
using BusinessLogicLayer.ServiceContracts;
using BusinessLogicLayer.Communication;

namespace BusinessLogicLayer.ServiceImplementations
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<OrderDetail> GetAllOrders()
        {
            return _unitOfWork.OrderDetails.Get();
        }

        public OrderDetailResponse SaveOrder(OrderDetail orderDetail)
        {
            try
            {
                _unitOfWork.OrderDetails.Insert(orderDetail);
                _unitOfWork.Commit();

                return new OrderDetailResponse(orderDetail);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new OrderDetailResponse($"An error occurred when saving the order: {ex.Message}");
            }
        }
    }
}
