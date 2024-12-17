using System.ComponentModel.DataAnnotations;

namespace Dealer.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

    }
}
