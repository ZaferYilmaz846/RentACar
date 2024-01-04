using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Dtos.VehicleModel
{
    public class VehicleModelForCreation
    {
        public string ModelName { get; set; }
        public int BrandID { get; set; }
        public int Year { get; set; }
        public string FuelOil { get; set; }
        public string Transmission { get; set; }
        public int PerDayPrice { get; set; }
    }
}
