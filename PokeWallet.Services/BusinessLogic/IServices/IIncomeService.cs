using PokeWallet.Models.IncomeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic.IServices
{
    public interface IIncomeService
    {
        Task<bool> CreateIncome(IncomeCreate model);
        Task<IncomeDetail> GetIncome(int id);
        Task<List<IncomeListItem>> GetIncomes();
        Task<bool> UpdateIncome(IncomeEdit model);
        Task<bool> DeleteIncome(int id);
    }
}
