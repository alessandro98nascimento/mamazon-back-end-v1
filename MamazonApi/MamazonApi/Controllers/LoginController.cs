/*
using MamazonApi.Repository.DTO;
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

        public ActionResult PostUser([FromBody] UserDTORequestLogin request) 
        {
            var reponse = _context.GetUser(request);

            if (reponse == null)  return BadRequest(new { });

            return Ok(new { token = "blablabla" });
        }
    }
}
*/