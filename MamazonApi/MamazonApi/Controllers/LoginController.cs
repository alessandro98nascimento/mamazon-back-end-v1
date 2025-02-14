using MamazonApi.Controllers.DTORequest;
using MamazonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MamazonApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _context;

        public LoginController() { _context = new LoginService(); }

        [HttpPost]
        [Route("/login")]

        public ActionResult PostUser([FromBody] RequestLogin data)
        {
            var reponse = _context.PostEmailPassword(data);

            if(reponse.Item2 == "Email ou senha invalida!") return BadRequest("Email ou senha invalida!");
            if(reponse.Item2 == "Usuário não encontrado!") return BadRequest("Usuário não encontrado!");
            if (reponse.Item2 == "Conta desativada!") return Unauthorized("Conta desativada!");
            return Ok(reponse.Item1);
        }
    }
}