
using Microsoft.AspNetCore.Mvc;
using startehouse.api.Data;
using startehouse.api.Domain.Model;
using startehouse.api.Services;

namespace startehouse.api.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {


        private readonly ConectionContext _contexts = new ConectionContext();

        // POST api/values
        [HttpPost]
        public IActionResult Auth(string user)
        {

            var hash = user;

            if (user == null) return BadRequest("Sem Dados de acesso!");

            var noDual = _contexts.Usuario.FirstOrDefault(x => x.Senha == hash);

            if(noDual == null) return BadRequest("Usuário ou Senha Inválida!!!");

            var token = TokenService.GenerateToken(noDual);
            return Ok(token);

        }
    }
}

