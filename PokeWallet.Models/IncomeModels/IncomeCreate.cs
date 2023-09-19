using PokeWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.IncomeModels
{
    public class IncomeCreate
    {        
        [Required]
        public string Month { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public int JobIncome { get; set; }
        
        public int OtherIncome { get; set; }

        [Required] 
        public int BudgetId { get; set; }
    }
}
