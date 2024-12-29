using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers
{
    [Route("api/Url")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        [HttpGet]
        public IActionResult shorten
    }
}
