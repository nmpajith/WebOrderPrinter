using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataTransferObjects
{
    public class CreateOrderDto
    {
        public string CustomerOrderId { get; set; }
        public int BranchId { get; set; }
        public string Order { get; set; }
    }
}
