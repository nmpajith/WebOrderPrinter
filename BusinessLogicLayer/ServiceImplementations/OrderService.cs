using System;
using System.Collections.Generic;
using DataAccessLayer.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models.Order;

namespace BusinessLogicLayer.ServiceImplementations
{
    public class OrderService
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
    }
}
