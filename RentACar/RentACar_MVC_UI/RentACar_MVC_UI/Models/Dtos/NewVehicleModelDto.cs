namespace RentACar_MVC_UI.Models.Dtos
{
    public class NewVehicleModelDto
    {
        public string ModelName { get; set; }
        public int BrandID { get; set; }
        public string Year { get; set; }
        public string FuelOil { get; set; }
        public string Transmission { get; set; }
        public int PerDayPrice { get; set; }
    }
}
