using MamazonApi.Repository.DTO;
using MamazonApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace MamazonApi.Controllers
{
    public class ForgetPasswordController : ControllerBase
    {
        private readonly ForgetPasswordService _context;

        public ForgetPasswordController() { _context = new ForgetPasswordService(); }

        [HttpPost]
        [Route("/forget-password")]

        public ActionResult PostUserByEmail([FromBody] UserEmailRequestDTO request)
        {
            var response = _context.PostUserByEmail(request);

            if (response == null) return BadRequest(new {});

            return Ok();
        }

        [HttpPut]
        [Route("/forget-Password")]
        public ActionResult PutPassword([FromBody] UserNewPasswordRequestDTO request)
        {
            var response = _context.PutPassword(request);
            if (response == null) return BadRequest();
            return NoContent();
        }
    }
}
