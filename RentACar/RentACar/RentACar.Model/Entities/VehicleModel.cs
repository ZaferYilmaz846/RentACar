using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Entities
{
    public class VehicleModel
    {
        public int VehicleModelID { get; set; }
        public string VehicleModelName { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleFuelOil { get; set; }
        public string VehicleTransmission { get; set; }
        public int PerDayPrice { get; set; }
        public int VehicleBrandID { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
    }
}
