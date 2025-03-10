namespace MamazonApi.Services.DTO
{
    
    public class ResponseDTOLogin
    {
        public UserDTO? User { get; set; } = null;
        public string? Message { get; set; } = null;

    }
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public int ActiveUser {  get; set; }
    }
}
