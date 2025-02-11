namespace MamazonApi.Repository.DTO
{
    public class UserEmailRequestDTO
    {
        public string? Email {  get; set; }   
    }

    public class UserNewPasswordRequestDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
