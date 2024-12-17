namespace Dealer.Repositories.Interfaces;

using Dealer.Models;
using System.Linq.Expressions;

public interface ICityRepository
{
    void Create(City city);
    List<City> Get();
    City Get(int cityId);
}
