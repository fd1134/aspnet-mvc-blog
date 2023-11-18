using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogAdmin.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
