namespace MamazonApi.Repository.DTO
{
    public class NewUserDTORequest
    {
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
    }
}
