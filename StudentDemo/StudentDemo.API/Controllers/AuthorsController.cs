using Microsoft.AspNetCore.Mvc;

namespace StudentDemo.API.Controllers

// <summary>
// AuthorsController - Yazar API Endpoint'lerini yöneten controller.
//
// SOLID: Singel Resposiblity Principle + Dependency Inversion
// </summary>
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService _authorService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
