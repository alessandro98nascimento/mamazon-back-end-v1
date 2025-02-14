using MamazonApi.Context;
using MamazonApi.Controllers.DTORequest;
using MamazonApi.Models;

namespace MamazonApi.Repository
{
    public class EmailsTable
    {
        private readonly AppDbContext _context;
        public EmailsTable()
        {
            _context = new AppDbContext();
        }

        public Email? PostEmail(RequestLogin data)
        {
            Email? responseDb = _context.Emails.FirstOrDefault((e) => e.UserEmail == data.Email);
            return responseDb;
        }
    }
}
