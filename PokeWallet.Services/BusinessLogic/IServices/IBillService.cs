using PokeWallet.Models.BillModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic.IServices
{
    public interface IBillService
    {
        Task<bool> CreateBill(BillCreate model);
        Task<BillDetail> GetBill(int id);
        Task<List<BillListItem>> GetBills();
        Task<bool> UpdateBill(BillEdit model);
        Task<bool> DeleteBill(int id);
    }
}
