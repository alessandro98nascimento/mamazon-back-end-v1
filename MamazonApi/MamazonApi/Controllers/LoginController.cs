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
            var response = _context.PostEmailPassword(data);

            if(response.User == null) return BadRequest(response.Message);
            return Ok(response.User);
        }
    }
}