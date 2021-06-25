﻿using BusinessLogicLayer.Models.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.Orders
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int BranchId { get; set; }
        public string Order { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Branch Branch { get; set; }
    }
}
