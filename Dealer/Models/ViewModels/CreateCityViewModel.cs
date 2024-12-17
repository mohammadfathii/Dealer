using Dealer.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Dealer.Models.ViewModels
{
    public class CreateCityViewModel
    {
        [Required]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
