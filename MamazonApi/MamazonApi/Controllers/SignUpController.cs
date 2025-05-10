using MamazonApi.Controllers.DTORequest;
using MamazonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MamazonApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly SignUpService _context;
        public SignUpController() { _context = new SignUpService(); }

        [HttpPost]
        [Route("/sign-Up")]

        public IActionResult PostNewUser(RequestNewUser newUser)
        {
            var newPassword = _context.AddNewUser(newUser);
        }
    }
}
