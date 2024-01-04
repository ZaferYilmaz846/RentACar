using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar_MVC_UI.Database;
using RentACar_MVC_UI.Models.Dtos;
using System;
using System.Net.Http;
using System.Text;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CorporateRentController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(CorporateDetailsDto cddto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:27766/api/CorporateDetail/add");

            string jsonString = JsonConvert.SerializeObject(cddto);
            StringContent stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(client.BaseAddress, stringContent).Result;
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Json(new { isSuccess = true, message = "Form Doldurma İşleminiz Başarıyla Gerçekleştirilmiştir..." });
            }
            
            else
            {
                return Json(new { isSuccess = false, });
            }
        }
    }
}
