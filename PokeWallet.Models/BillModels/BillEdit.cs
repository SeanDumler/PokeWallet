using PokeWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BillModels
{
    public class BillEdit
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
                
        [Required]
        public int Cost { get; set; }

        [Required]
        public int BudgetId { get; set; }        
    }
}
