using Dealer.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dealer.Models
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        [RegularExpression("/[0-9]")]
        public int DealerNo { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public int CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public City City { get; set; }
    }
}
