using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new List<Product>
        {
            new Product {Id= 1, Name = "Kamp Çadırı" },
            new Product {Id= 2, Name = "Uyku Tulumu" },
            new Product {Id= 3, Name = "Kamp Matı" },
            new Product {Id= 4, Name = "Kamp Sandalyesi" },
            new Product {Id= 5, Name = "Paslanmaz Çelik Termos" },
            new Product {Id= 6, Name = "Batonlar" },
            new Product {Id= 7, Name = "Kayak Ayakkabıları" },
            new Product {Id= 8, Name = "Kayak Giysileri" },
            new Product {Id= 9, Name = "Kayak Gözlükleri" },
            new Product {Id= 10, Name = "Kayaklar" },
            new Product {Id= 11, Name = "Trekking Bot" },
            new Product {Id= 12, Name = "Kask" },
            new Product {Id= 13, Name = "Karabina" },
            new Product {Id= 14, Name = "Şişme Bot" },
            new Product {Id= 15, Name = "Palet" },
        };
        private static int _idCounter = 16;

        #region READ 
        public IActionResult Index()
        {
            string adminCookie = Request.Cookies["admin"];
            if (string.IsNullOrEmpty(adminCookie))
            {
                return RedirectToAction("Index", "Home");
            }
            return View(_products);

        }
        #endregion

        #region CREATE
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product model)
        {
            model.Id = _idCounter++;
            _products.Add(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region UPDATE
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            var product = _products.FirstOrDefault(p => p.Id == model.Id);
            if (product != null)
            {
                product.Name = model.Name;
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region DELETE
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            var product = _products.FirstOrDefault(p => p.Id == model.Id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return RedirectToAction("Index");
            
        }
        #endregion
    }
}
