using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        [HttpGet("Getlist")]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new[] { "Zahit", "Gani", ".Net Core 4.0", "Json Web Token", "Swagger", "-Authorize", "İşlemleri" };
        }
    }
}
