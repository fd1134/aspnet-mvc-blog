using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogAdmin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult UserList()
        {
            return View();
        }
    }
}
