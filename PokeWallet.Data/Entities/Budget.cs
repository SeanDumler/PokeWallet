using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWallet.Data.Entities
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        public string OwnerId { get; set; } = string.Empty;

        [Required]
        public string Month { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        public int AvailableFunds { get; set; }

        public List<Bill> Bills { get; set; } = new List<Bill>();

        public List<Income> Incomes { get; set; } = new List<Income>();
    }
}
