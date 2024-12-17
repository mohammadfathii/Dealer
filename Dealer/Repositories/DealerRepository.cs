using Dealer.Data;
using Dealer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dealer.Repositories
{
    public class DealerRepository : IDealerRepository
    {
        private readonly DealerDbContext _context;
        public DealerRepository(DealerDbContext dealer)
        {
            _context = dealer;
        }

        public Models.Dealer Create(Models.Dealer dealer)
        {
            _context.Dealers.Add(dealer);
            _context.SaveChanges();

            return dealer;
        }

        public List<Models.Dealer> Get()
        {
            var dealers = _context.Dealers.ToList();
            return dealers;
        }

        public Models.Dealer Get(int dealerId)
        {
            var dealer = _context.Dealers.FirstOrDefault(d => d.Id == dealerId);
            return dealer;
        }
    }
}
