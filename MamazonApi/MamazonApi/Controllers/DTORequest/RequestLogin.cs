namespace MamazonApi.Controllers.DTORequest
{
    public class RequestLogin
    {
        public required string Email { get; set; }
        public string? Password { get; set; }
    }
}
