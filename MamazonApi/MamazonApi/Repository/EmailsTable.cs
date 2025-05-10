using MamazonApi.Context;
using MamazonApi.Controllers.DTORequest;
using MamazonApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MamazonApi.Repository
{
    public class EmailsTable
    {
        private readonly AppDbContext _context;
        public EmailsTable()
        {
            _context = new AppDbContext();
        }

        public Email? PostEmail(string emailUser)
        {
            Email? responseDb = _context.Emails.FirstOrDefault((e) => e.UserEmail == emailUser);
            return responseDb;
        }
    }
}
