using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.Dtos;
using MVCApp.Models;

namespace MVCApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();


            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.id, opt => opt.Ignore());
        }
    }
}