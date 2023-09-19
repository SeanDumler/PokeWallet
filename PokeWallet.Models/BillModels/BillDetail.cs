using PokeWallet.Data.Entities;
using PokeWallet.Models.BudgetModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BillModels
{
    public class BillDetail
    {        
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        
        public int Cost { get; set; }

        public BudgetListItem Budget { get; set; } = null!;
    }
}
