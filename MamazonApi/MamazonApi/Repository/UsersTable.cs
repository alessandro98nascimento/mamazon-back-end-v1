using MamazonApi.Context;
using MamazonApi.Models;
using MamazonApi.Repository.DTO;

namespace MamazonApi.Repository
{
    public class UsersTable
    {
        private readonly AppDbContext _context;
        public UsersTable() 
        {
            _context = new AppDbContext();        
        }

        public User? GetUser(UserDTORequestLogin request)
        {
            var dbResponse = _context.Users.FirstOrDefault(user => user.Email == request.Email && user.Password == request.Password);
            return dbResponse;
        }
    }
}
