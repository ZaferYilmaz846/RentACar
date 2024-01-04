using RentACar_MVC_UI.Models.Dtos;
using System.Collections.Generic;

namespace RentACar_MVC_UI.Models.Entities
{
    public class VehicleModelView
    {
        public List<ApiVehicleBrandGetDto> VehicleBrands { get; set; }
        public List<ApiVehicleModelGetDto> VehicleModels { get; set; }
    }
}
