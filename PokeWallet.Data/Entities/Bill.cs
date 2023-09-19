using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeWallet.Data.Entities
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Cost { get; set; }

        public int BudgetId { get; set; }

        [ForeignKey(nameof(BudgetId))]
        public virtual Budget Budget { get; set; } = null!;
    }
}
