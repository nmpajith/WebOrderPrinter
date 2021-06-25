using BusinessLogicLayer.Models.Restaurants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Contexts
{
    public class WebOrderPrinterDbContext : DbContext
    {
        public DbSet<Restaurant> Categories { get; set; }
        public DbSet<Branch> Products { get; set; }

        public WebOrderPrinterDbContext() : base() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);           

        }
    }
}
