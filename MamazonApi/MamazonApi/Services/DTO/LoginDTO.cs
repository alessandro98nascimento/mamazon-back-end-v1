namespace MamazonApi.Services.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Adress { get; set; }
        public int NumberHouse { get; set; }
        public int Cep { get; set; }
        public string? Complement { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int ActiveUser { get; set; }
    }
    
    public class MessageDTO
    {
        public string? Message { get; set; }
    }
}
