using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogAdmin.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
