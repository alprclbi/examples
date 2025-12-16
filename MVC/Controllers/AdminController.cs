using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        private static string Admin = "admin";
        private static string Password = "123";


        [HttpPost]
        public IActionResult Login(AdminViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["LoginError"] = "Kullanıcı adı veya şifre boş bırakılamaz.";
                return RedirectToAction("Index", "Home");
            }
            if(model.Username == Admin && model.Password == Password)
            {
                CookieOptions cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    IsEssential = true,
                };
                if (model.RememberMe)
                {
                    cookieOptions.Expires = DateTimeOffset.UtcNow.AddDays(7);
                }
                Response.Cookies.Append("admin", model.Username, cookieOptions);

                return RedirectToAction("Index", "Home");
            }
            TempData["LoginError"] = "Kullanıcı adı veya şifre hatalı.";
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("admin");
            return RedirectToAction("Index", "Home");
        }
    }
}
