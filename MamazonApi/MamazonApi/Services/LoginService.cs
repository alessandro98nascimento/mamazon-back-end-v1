using Azure;
using MamazonApi.Context;
using MamazonApi.Models;
using MamazonApi.Repository;
using MamazonApi.Repository.DTO;
using MamazonApi.Services.DTO;
using Microsoft.EntityFrameworkCore;

namespace MamazonApi.Services
{
    public class LoginService
    {
        private readonly UsersTable _context;

        public LoginService()
        {
            _context = new UsersTable();
        }

        public LoginService(AppDbContext? context) { _context = new UsersTable(); }

        public UserDTO? GetUser(UserDTORequestLogin request)
        {
            var responseDb = _context.GetUser(request);

            if (responseDb == null) return null;
            

            UserDTO user = new UserDTO
            {
                UserId = responseDb.UserId,
                UserName = responseDb.UserName,
                Email = responseDb.Email,
                Password = responseDb.Password,
                Adress = responseDb.Adress,
                NumberHouse = responseDb.NumberHouse,
                Cep = responseDb.Cep,
                Complement = responseDb.Complement,
                Neighborhood = responseDb.Neighborhood,
                City = responseDb.City,
                State = responseDb.State,
                ActiveUser = responseDb.ActiveUser,
            };

            return user;
        }
    }
}
