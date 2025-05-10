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

        public Password? PostPassword(int passwordId)
        {
            Password? reponseDb = _context.Passwords.FirstOrDefault((p) => p.PasswordId == passwordId);
            return reponseDb;
        }

        public Password? PutPassword(int passwordId, string newPassword)
        {
            Password? oldPassword = PostPassword(passwordId);
            if(oldPassword == null) return null;
            oldPassword.UserPassword = newPassword;
            _context.Passwords.Update(oldPassword);
            _context.SaveChanges();
            return oldPassword;
        }
    }
}
