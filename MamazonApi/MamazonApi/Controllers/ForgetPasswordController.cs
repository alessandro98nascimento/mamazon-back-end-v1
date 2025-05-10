using MamazonApi.Controllers.DTORequest;
using MamazonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MamazonApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ForgetPasswordController : ControllerBase
    {
        private readonly ForgetPasswordService _context;

        public ForgetPasswordController() { _context = new ForgetPasswordService(); }

        [HttpPost]
        [Route("/forget-password")]

        public IActionResult PostEmail([FromBody] RequestEmail request)
        {
            bool emailExist = _context.ExistEmail(request);
            if (emailExist == false) return BadRequest();
            return Ok();
        }

        [HttpPut]
        [Route("/forget-password")]

        public IActionResult PutPassword([FromBody] RequestUpdatePassword request)
        {
            var response = _context.UpdatePassword(request);
            if(!response) return BadRequest();
            return Ok(response);
        }
    }
}
