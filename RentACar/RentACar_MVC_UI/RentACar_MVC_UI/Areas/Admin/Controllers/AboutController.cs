using Microsoft.AspNetCore.Mvc;

namespace RentACar_MVC_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
