using Azure.Core;
using MamazonApi.Models;
using MamazonApi.Repository;
using MamazonApi.Repository.DTO;

namespace MamazonApi.Services
{
    public class SignUpService
    {
        private readonly UsersTable _context;

        public SignUpService(){ _context = new UsersTable(); }

        public User? AddNewUser(NewUserDTORequest request)
        {
            User? newUser = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                Password = request.Password,
                Adress = request.Adress,
                NumberHouse = request.NumberHouse,
                Cep = request.Cep,
                Complement = request.Complement,
                Neighborhood = request.Neighborhood,
                City = request.City,
                State = request.State,
                ActiveUser = 1
            };
            User? responseDb = _context.PostNewUser(newUser);

            return responseDb;
        }
    }
}
