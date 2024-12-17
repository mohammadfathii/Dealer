using Dealer.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Dealer.Models.ViewModels
{
    public class CreateDealerViewModel
    {
        [Required]
        public int Code { get; set; }
        [Required]
        public int DealerNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int CityId { get; set; }
    }
}
