using DataAccessLayer.Persistence.Contexts;
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
    public class UnitOfWork : IUnitOfWork
    {

        private WebOrderPrinterDbContext _dbContext;
        private BaseRepository<DeviceDetail> _deviceDetails;
        private BaseRepository<OrderDetail> _orderDetails;
        private BaseRepository<Restaurant> _restaurants;
        private BaseRepository<Branch> _branches;
        private BaseRepository<Notification> _notifications;

        public UnitOfWork(WebOrderPrinterDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<DeviceDetail> DeviceDetails => _deviceDetails ??= new BaseRepository<DeviceDetail>(_dbContext);

        public IRepository<OrderDetail> OrderDetails => _orderDetails ??= new BaseRepository<OrderDetail>(_dbContext);

        public IRepository<Restaurant> Restaurants => _restaurants ??= new BaseRepository<Restaurant>(_dbContext);

        public IRepository<Branch> Branches => _branches ??= new BaseRepository<Branch>(_dbContext);

        public IRepository<Notification> Notifications => _notifications ??= new BaseRepository<Notification>(_dbContext);

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
