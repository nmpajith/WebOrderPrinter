using BusinessLogicLayer.Models.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Devices
{
    //Test Comment
    public class DeviceDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Branch Branch { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}
