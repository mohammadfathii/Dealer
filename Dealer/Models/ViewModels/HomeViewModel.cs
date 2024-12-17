using Dealer.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Dealer.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Dealer> Dealers { get; set; }
        public List<City> Cities { get; set; }
    }
}
