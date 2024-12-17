using Dealer.Data;
using Dealer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dealer.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DealerDbContext _context;
        public CityRepository(DealerDbContext dealer)
        {
            _context = dealer;
        }

        public void Create(Models.City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }

        public List<Models.City> Get()
        {
            var cities = _context.Cities.ToList();
            return cities;
        }

        public Models.City Get(int cityId)
        {
            var city = _context.Cities.FirstOrDefault(d => d.Id == cityId);
            return city;
        }
    }
}
