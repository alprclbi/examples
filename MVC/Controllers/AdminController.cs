using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        // Admin ve parola sabit property tanımladık.
        private static string Admin = "admin";
        private static string Password = "123";

        // Giriş işlemi için POST metodu oluşturuldu.
        [HttpPost]
        public IActionResult Login(AdminViewModel model) //AdminViewModel post edildi parametre olarak alındı.
        {
            if (!ModelState.IsValid)
            {
                //Attiribute ile doğrulama vardı ama Redirect yaparken ModelState kayboluyor. O yüzden TempData kullanıldı.
                TempData["LoginError"] = "Kullanıcı adı veya şifre boş bırakılamaz.";
                return RedirectToAction("Index", "Home");
            }
            //Kullanıcıdan gelen bilgiler sabitlerle karşılaştırıldı.
            if (model.Username == Admin && model.Password == Password)
            {
                //Giriş başarılı ise cookie oluşturuldu.
                CookieOptions cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    IsEssential = true,
                };
                // RememberMe seçeneği işaretlendiyse cookie süresi uzatıldı.
                if (model.RememberMe)
                {
                    cookieOptions.Expires = DateTimeOffset.UtcNow.AddMinutes(60);
                }
                // Cookie eklendi.
                Response.Cookies.Append("admin", model.Username, cookieOptions);

                return RedirectToAction("Index", "Home");
            }

            //TempData ile hata mesajı gönderildi.
            TempData["LoginError"] = "Kullanıcı adı veya şifre hatalı.";
            return RedirectToAction("Index", "Home");
        }

        // Çıkış işlemi için POST metodu oluşturuldu.
        [HttpPost]
        public IActionResult Logout()
        {
            // Cookie silme işlemi
            Response.Cookies.Delete("admin");
            return RedirectToAction("Index", "Home");
        }
    }
}
