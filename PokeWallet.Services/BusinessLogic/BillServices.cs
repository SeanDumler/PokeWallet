using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokeWallet.Data.Data;
using PokeWallet.Data.Entities;
using PokeWallet.Models.BillModels;
using PokeWallet.Services.BusinessLogic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic
{
    public class BillServices : IBillService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public BillServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateBill(BillCreate model)
        {
            var bill = _mapper.Map<Bill>(model);
            await _context.Bills.AddAsync(bill);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteBill(int id)
        {
            var bill = await _context.Bills.FindAsync(id);
            if (bill is null) return false;
            _context.Bills.Remove(bill);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<BillDetail> GetBill(int id)
        {
            var bill = await _context.Bills.FindAsync(id);
            if (bill is null) return new BillDetail();

            return _mapper.Map<BillDetail>(bill);
        }

        public async Task<List<BillListItem>> GetBills()
        {
            var bills = await _context.Bills.ToListAsync();
            return _mapper.Map<List<BillListItem>>(bills);
        }

        public async Task<bool> UpdateBill(BillEdit model)
        {
            var bill = await _context.Bills.FindAsync(model.Id);
            if (bill is null) return false;

            bill.Name = model.Name;
            bill.Cost = model.Cost;
            bill.BudgetId = model.BudgetId;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
