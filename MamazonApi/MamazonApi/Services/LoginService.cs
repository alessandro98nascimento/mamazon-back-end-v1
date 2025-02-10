using MamazonApi.Context;
using MamazonApi.Models;
using MamazonApi.Repository;
using MamazonApi.Repository.DTO;
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

        public User? GetUser(UserDTORequestLogin request)
        {   
            var responseDb = _context.GetUser(request);
            return responseDb;
        }

    }
}
