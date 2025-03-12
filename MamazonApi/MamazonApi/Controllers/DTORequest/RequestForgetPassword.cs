namespace MamazonApi.Controllers.DTORequest
{
    public class RequestEmail
    {
        public required string Email { get; set; }
    }

    public class RequestUpdatePassword
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
