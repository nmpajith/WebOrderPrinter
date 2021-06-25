using BusinessLogicLayer.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Restaurants
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public IList<Branch> Branches { get; set; } = new List<Branch>();
        public IList<Contact> Contacts { get; set; }
        public Address Address { get; set; }
    }
}
