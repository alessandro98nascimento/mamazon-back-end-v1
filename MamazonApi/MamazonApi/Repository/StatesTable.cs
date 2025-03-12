using MamazonApi.Context;

namespace MamazonApi.Repository
{
    public class StatesTable
    {
        private readonly AppDbContext _context;
        public StatesTable() { _context = new AppDbContext(); }
    }
}
