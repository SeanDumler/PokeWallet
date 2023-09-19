using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWallet.Data.Entities
{
    public class Income
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Month { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public int JobIncome { get; set; }

        [Required]
        public int OtherIncome { get; set; }

        public int BudgetId { get; set; }

        [ForeignKey(nameof(BudgetId))]
        public virtual Budget Budget { get; set; } = null!;
    }
}
