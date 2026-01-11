using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;


namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _projectContext;

        public HomeController(ILogger<HomeController> logger, ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var productList = _projectContext.Products
                .Include(p => p.Category)
                .Include(P => P.Brand)
                .Where(p => p.Price > 500 && p.Name.Contains("a"))
                .Skip(0).Take(10)
                .OrderBy(p => p.Price)
                .ToList();

            return View(productList);
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
