using MamazonApi.Context;
using MamazonApi.Models;

namespace MamazonApi.Repository
{
    public class UsersTable
    {
        private readonly AppDbContext _context;
        public UsersTable() 
        {
            _context = new AppDbContext();        
        }

        public User? PostUser(Email email, Password password) 
        {
            User? responseDb = _context.Users.FirstOrDefault(u => u.EmailId == email.EmailId && u.PasswordId == password.PasswordId);
            return responseDb;
        }
    }
}
