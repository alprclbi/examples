using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {

        //string static username password property tanımla attirbute koy.
        //method yaz.
        //validasyon yap eğer uyuşuyorsa.
        //tarayıcının cookiesine username kaydet.
        //cokkie doluysa sayfada hoşgeldin alper çelebi, ürün listesi sayfasına yönlendir.
        //orda cookie dolu değilse giriş yap ekranına yönlendir  
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
