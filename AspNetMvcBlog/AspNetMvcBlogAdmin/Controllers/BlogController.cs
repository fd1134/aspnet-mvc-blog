using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogAdmin.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult BlogList()
        {
            return View();
        }

        public IActionResult BlogDetail()
        {
            return View();
        }

    }
}
