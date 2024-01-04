using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Dtos.VehicleModel
{
    public class VehicleModelDeleteDto
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public int Year { get; set; }
        public string FuelOil { get; set; }
        public string Transmission { get; set; }
        public int PerDayPrice { get; set; }
    }
}
