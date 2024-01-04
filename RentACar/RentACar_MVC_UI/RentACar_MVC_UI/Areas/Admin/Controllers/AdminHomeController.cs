using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            string jsonStr = HttpContext.Session.GetString("LoggedInAdmin");
            if (string.IsNullOrEmpty(jsonStr))
            {
                return Redirect("/Admin/Authentication/Login");
            }

            return View();
        }
    }
}
