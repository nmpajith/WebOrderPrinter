using System;
using System.Collections.Generic;
using DataAccessLayer.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServiceImplementations
{
    public class OrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetAllOrders()
        {
            return _unitOfWork.OrderDetails.Get();
        }
    }
}
