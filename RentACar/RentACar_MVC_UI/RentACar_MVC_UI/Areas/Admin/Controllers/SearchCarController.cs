using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar_MVC_UI.Models.Dtos;
using RentACar_MVC_UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    public class SearchCarController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/getall");
            HttpResponseMessage responseMessage = client.GetAsync(client.BaseAddress).Result;
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                VehicleModelView vehicleModel = new VehicleModelView();
                string jsonContent = responseMessage.Content.ReadAsStringAsync().Result;
                vehicleModel.VehicleModels = JsonConvert.DeserializeObject<List<ApiVehicleModelGetDto>>(jsonContent);

                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/getall");
                responseMessage = client.GetAsync(client.BaseAddress).Result;
                jsonContent = responseMessage.Content.ReadAsStringAsync().Result;
                vehicleModel.VehicleBrands = JsonConvert.DeserializeObject<List<ApiVehicleBrandGetDto>>(jsonContent);
                return View(vehicleModel);
            }

            return null;
        }
    }
}
