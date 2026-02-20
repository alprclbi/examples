using Microsoft.AspNetCore.Mvc;

namespace Author_Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
        public class ApiController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get(string bookName)
            {
                return Ok(bookName);
            }

            [HttpPost]
            public IActionResult Post(string bookName)
            {
                return Ok(bookName);
            }
        }
}
