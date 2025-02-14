using MamazonApi.Context;
using MamazonApi.Controllers.DTORequest;
using MamazonApi.Models;

namespace MamazonApi.Repository
{
    public class PasswordsTable
    {
        private readonly AppDbContext _context;
        public PasswordsTable()
        {
            _context = new AppDbContext();
        }

        public Password? PostPassword(RequestLogin data)
        {
            Password? reponseDb = _context.Passwords.FirstOrDefault((p) => p.UserPassword == data.Password);
            return reponseDb;
        }
    }
}
