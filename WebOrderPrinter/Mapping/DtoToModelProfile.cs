using AutoMapper;
using Infrastructure.DataTransferObjects;
using Infrastructure.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOrderPrinter.Mapping
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        { CreateMap<CreateOrderDto, OrderDetail>(); }



    }
}
