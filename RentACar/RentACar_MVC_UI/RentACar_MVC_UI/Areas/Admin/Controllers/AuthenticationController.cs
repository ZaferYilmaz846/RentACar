using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;
using RentACar_MVC_UI.Areas.Admin.Validation;
using RentACar_MVC_UI.Database;
using RentACar_MVC_UI.Models.Dtos;
using System.Linq;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {
            LoginDtoValidator validator = new LoginDtoValidator();
            ValidationResult result = validator.Validate(dto);
            if (result.IsValid)
            {
                ContextDB context = new ContextDB();
                var user = context.Users.SingleOrDefault(x => x.UserName == dto.UserName && x.Password == dto.Password);
                if (user == null)
                {
                    return Json(new { isSuccess = false, Message = "Kullanıcı Bulunamadı..." });
                }

                var jsonStr = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("LoggedInAdmin", jsonStr);

                return Json(new { isSuccess = true });
            }

            else
            {
                string hataMesaji = "<div class='alert alert-danger'>";
                foreach (ValidationFailure item in result.Errors)
                {
                    hataMesaji += $"<b>{item.ErrorMessage}</b></br>";
                }

                hataMesaji += "</div>";
                return Json(new { isSuccess = false, Message = hataMesaji });
            }



        }
    }
}
