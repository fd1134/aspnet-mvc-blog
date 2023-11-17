using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }

    }
}
