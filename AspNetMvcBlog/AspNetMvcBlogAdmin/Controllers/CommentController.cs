using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlogAdmin.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult CommentList()
        {
            return View();
        }
    }
}
