using PokeWallet.Data.Entities;
using PokeWallet.Models.BillModels;
using PokeWallet.Models.IncomeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BudgetModels
{
    public class BudgetDetail
    {
        public int Id { get; set; }

        public string OwnerId { get; set; } = null!;

        public string Month { get; set; } = string.Empty;
        
        public int Year { get; set; }
               
        public int AvailableFunds { get; set; }

        public List<BillListItem> Bills { get; set; } = new List<BillListItem>();

        public List<IncomeListItem> Incomes { get; set; } = new List<IncomeListItem>();
    }
}
