using AutoMapper;
using RentACar.Model.Dtos.VehicleBrand;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.BusinessLayer.Mappers
{
    public class VehicleBrandProfile : Profile
    {
        public VehicleBrandProfile()
        {
            CreateMap<VehicleBrand, VehicleBrandGetDto>().ForMember(dto => dto.BrandID, entity => entity.MapFrom(x => x.VehicleBrandID)).ForMember(dto => dto.BrandName, entity => entity.MapFrom(x => x.VehicleBrandName));
        }
    }
}
