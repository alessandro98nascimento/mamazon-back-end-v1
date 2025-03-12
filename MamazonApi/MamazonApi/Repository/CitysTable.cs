using MamazonApi.Context;

namespace MamazonApi.Repository
{
    public class CitysTable
    {
        private readonly AppDbContext _context;
        public CitysTable() { _context = new AppDbContext(); }
    }
}
