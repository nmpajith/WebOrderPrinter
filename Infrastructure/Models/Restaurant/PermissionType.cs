using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Restaurant
{
    public class PermissionType
    {
        public int Id { get; set; }
        public EPermissionTypeNames PermissionTypeName { get; set; }
        public Permission Permission { get; set; }
    }
}
