using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokeWallet.Data.Data;
using PokeWallet.Data.Entities;
using PokeWallet.Models.BillModels;
using PokeWallet.Models.IncomeModels;
using PokeWallet.Services.BusinessLogic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic
{
    public class IncomeServices : IIncomeService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public IncomeServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateIncome(IncomeCreate model)
        {
            var income = _mapper.Map<Income>(model);
            await _context.Incomes.AddAsync(income);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteIncome(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income is null) return false;
            _context.Incomes.Remove(income);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IncomeDetail> GetIncome(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income is null) return new IncomeDetail();

            return _mapper.Map<IncomeDetail>(income);
        }

        public async Task<List<IncomeListItem>> GetIncomes()
        {
            var incomes = await _context.Incomes.ToListAsync();
            return _mapper.Map<List<IncomeListItem>>(incomes);
        }

        public async Task<bool> UpdateIncome(IncomeEdit model)
        {
            var income = await _context.Incomes.FindAsync(model.Id);
            if (income is null) return false;

            income.Month = model.Month;
            income.Year = model.Year;
            income.JobIncome = model.JobIncome;
            income.OtherIncome = model.OtherIncome;
            income.BudgetId = model.BudgetId;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
