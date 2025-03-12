using MamazonApi.Context;

namespace MamazonApi.Repository
{
    public class ResidencesUsersTable
    {
        private readonly AppDbContext _context;
        public ResidencesUsersTable() { _context = new AppDbContext(); }
    }
}
