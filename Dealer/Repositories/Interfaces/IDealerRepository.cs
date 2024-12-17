namespace Dealer.Repositories.Interfaces;

using Dealer.Models;
using System.Linq.Expressions;

public interface IDealerRepository
{
    Dealer Create(Dealer dealer);
    List<Dealer> Get();
    Dealer Get(int dealerId);
}
