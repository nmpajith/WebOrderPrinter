using Infrastructure.Models.Device;
using Infrastructure.Models.Notifications;
using Infrastructure.Models.Order;
using Infrastructure.Models.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<DeviceDetail> DeviceDetails { get; }
        IRepository<OrderDetail> OrderDetails { get; }
        IRepository<Restaurant> Restaurants { get; }
        IRepository<Branch> Branches { get; }
        IRepository<Notification> Notifications { get; }
        void Commit();
    }
}
