using PokeWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BillModels
{
    public class BillCreate
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public int Cost { get; set; }

        [Required]
        public int BudgetId { get; set; }
    }
}
