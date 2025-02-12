using MamazonApi.Repository.DTO;
using MamazonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MamazonApi.Controllers
{
    public class SignUpController: ControllerBase
    {
        public readonly SignUpService _context;

        public SignUpController() { _context = new SignUpService(); }

        [HttpPost]
        [Route("/SignUp")]

        public ActionResult PostNewUser([FromBody] NewUserDTORequest request)
        {

            var response = _context.AddNewUser(request);

            return Created("Created", response);
        }


    }
}
