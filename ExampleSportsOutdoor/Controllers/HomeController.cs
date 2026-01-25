using System.Diagnostics;
using ExampleSportsOutdoor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampleSportsOutdoor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _projectContext;

        public HomeController(ILogger<HomeController> logger, ProjectContext projectContext)
        {
            _logger = logger;
            _projectContext = projectContext;
        }

        public IActionResult Index()
        {
            var product = _projectContext.Products
                .Include(x => x.ProductImages)
                .ToList();
            var categories = _projectContext.Categories
                .ToList();
            return View((product, categories));
        }

        public IActionResult ProductDetail(int id)
        {
            var product = _projectContext.Products
                .Include(x => x.ProductImages)
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.ProductColors).ThenInclude(x => x.Color)
                .Include(x => x.ProductSizes).ThenInclude(x => x.Size)
                .Include(x => x.ProductProperties)
                .FirstOrDefault(X => X.Id == id);
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
