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
    public class IncomeListItem
    {        
        public int Id { get; set; }
        
        public string Month { get; set; } = string.Empty;
        
        public int Year { get; set; }
        
        public int JobIncome { get; set; }
        
        public int BudgetId { get; set; }
    }
}
