using PokeWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Models.BudgetModels
{
    public class BudgetEdit
    {
        [Required]
        public int Id { get; set; }               
                
        [Required]
        public string Month { get; set; } = string.Empty;
        
        [Required]
        public int Year { get; set; }
        
        [Required]
        public int AvailableFunds { get; set; }
    }
}
