using MamazonApi.Context;

namespace MamazonApi.Repository
{
    public class ResidencesTable
    {
        private readonly AppDbContext _context;
        public ResidencesTable() { _context = new AppDbContext(); }
    }
}
