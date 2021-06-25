using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Restaurants
{
    public class Permission
    {
        public int Id { get; set; }
        public int PermissionTypeId { get; set; }
        public int ContactId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public PermissionType PermissionType { get; set; }
        public Contact Contact { get; set; }
    }
}
