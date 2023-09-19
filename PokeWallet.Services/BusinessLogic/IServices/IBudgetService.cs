using PokeWallet.Models.BudgetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic.IServices
{
    public interface IBudgetService
    {
        Task<bool> CreateBudget(BudgetCreate model);
        Task<BudgetDetail> GetBudget(int id);
        Task<List<BudgetListItem>> GetBudgets();
        Task<bool> UpdateBudget(BudgetEdit model);
        Task<bool> DeleteBudget(int id);
             
    }
}
