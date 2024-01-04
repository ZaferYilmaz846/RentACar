using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;
using RentACar_MVC_UI.Models.Dtos;
using RentACar_MVC_UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VehicleModelController : Controller
    {
        public IActionResult Index()
        {
            string jsonStr = HttpContext.Session.GetString("LoggedInAdmin");
            if (string.IsNullOrEmpty(jsonStr))
            {
                return Redirect("/Admin/Authentication/Login");
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/getall");
            HttpResponseMessage responseMessage = client.GetAsync(client.BaseAddress).Result;

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                VehicleModelView vehicleModel = new VehicleModelView();

                string jsonContent = responseMessage.Content.ReadAsStringAsync().Result;
                vehicleModel.VehicleModels = JsonConvert.DeserializeObject<List<ApiVehicleModelGetDto>>(jsonContent);

                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:27766/api/VehicleBrand/getall");
                responseMessage = client.GetAsync(client.BaseAddress).Result;
                jsonContent = responseMessage.Content.ReadAsStringAsync().Result;
                vehicleModel.VehicleBrands = JsonConvert.DeserializeObject<List<ApiVehicleBrandGetDto>>(jsonContent);
                return View(vehicleModel);
            }


            return null;
        }



        [HttpPost]
        public IActionResult Insert(NewVehicleModelDto dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/add");

            var jsonStr = JsonConvert.SerializeObject(dto);
            StringContent content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = client.PostAsync(client.BaseAddress, content).Result;
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Json(new { isSuccess = true, Message = "Araç Başarılı Bir Şekilde Kaydedilmiştir..." });
            }

            else
            {
                return Json(new { isSuccess = false });
            }
        }


        [HttpPost]
        public IActionResult Update(UpdatedVehicleModelDto udto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/update");
            string jsonString = JsonConvert.SerializeObject(udto);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = client.PostAsync(client.BaseAddress, content).Result;

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Json(new { isSuccess = true, message = "Araç Başarılı Bir Şekilde Güncellenmiştir..." });
            }

            else
            {
                return Json(new { isSuccess = false });
            }
        }


        [HttpPost]
        public IActionResult Delete(DeleteVehicleModelDto ddto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/VehicleModel/delete");

            string jsonString = JsonConvert.SerializeObject(ddto);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(client.BaseAddress, content).Result;
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Json(new { isSuccess = true, message = "Araç Başarılı Bir Şekilde Silinmiştir!!!!" });
            }

            else
            {
                return Json(new { isSuccess = false });
            }
        }


    }
}
