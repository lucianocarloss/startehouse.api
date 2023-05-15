
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Domain.Model;
using startehouse.api.Services;

namespace startehouse.api.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {

            //https://localhost:7060/api/v1/auth?username=luciano&password=123456&api-version=1.0
            //https://localhost:7060/api/v1/auth?username=luluca&password=12345&api-version=1.0
            if (username == "luciano" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Person());
                return Ok(token);
            }

            return BadRequest("Usuário ou Senha Inválida!!!");
        }
    }
}

