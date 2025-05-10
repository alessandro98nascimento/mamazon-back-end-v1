namespace MamazonApi.Controllers.DTORequest
{
    public class RequestNewUser
    {
        public string? UserName { get; set; }
        public string? StateName { get; set; }
        public string? Adress { get; set; }
        public int NumberHouse { get; set; }
        public int Cep { get; set; }
        public string? Neighborhood { get; set; }
        public string? Complement { get; set; }
        public string? Password { get; set; }
        public string? UserEmail { get; set; }
        public string? CityName { get; set; }
    }
}
