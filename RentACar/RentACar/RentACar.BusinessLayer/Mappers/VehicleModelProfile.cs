using AutoMapper;
using RentACar.Model.Dtos.VehicleModel;
using RentACar.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.BusinessLayer.Mappers
{
    public class VehicleModelProfile : Profile
    {
        public VehicleModelProfile()
        {
            CreateMap<VehicleModelForCreation, VehicleModel>();
            CreateMap<VehicleModel, VehicleModelDeleteDto>();
            CreateMap<VehicleModel, VehicleModelUpdateDto>();
            CreateMap<VehicleModel, VehicleModelGetDto>()
                .ForMember(dto => dto.ModelID, entity => entity.MapFrom(x => x.VehicleModelID))
                .ForMember(dto => dto.ModelName, entity => entity.MapFrom(x => x.VehicleModelName))
                .ForMember(dto => dto.Year, entity => entity.MapFrom(x => x.VehicleYear))
                .ForMember(dto => dto.FuelOil, entity => entity.MapFrom(x => x.VehicleFuelOil))
                .ForMember(dto => dto.Transmission, entity => entity.MapFrom(x => x.VehicleTransmission))
                .ForMember(dto => dto.PerDayPrice, entity => entity.MapFrom(x => x.PerDayPrice))
                .ForMember(dto => dto.BrandName, entity => entity.MapFrom(x => x.VehicleBrand.VehicleBrandName));
            
        }
    }
}
