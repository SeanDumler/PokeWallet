using PokeWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BudgetModels
{
    public class BudgetListItem
    {        
        public int Id { get; set; }

        public string OwnerId { get; set; } = null!;

        public string Month { get; set; } = string.Empty;
        
        public int Year { get; set; }
        
        public int AvailableFunds { get; set; }
    }
}
