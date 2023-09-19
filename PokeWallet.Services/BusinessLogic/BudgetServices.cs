using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PokeWallet.Data.Data;
using PokeWallet.Data.Entities;
using PokeWallet.Models.BudgetModels;
using PokeWallet.Services.BusinessLogic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.BusinessLogic
{
    public class BudgetServices : IBudgetService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        private readonly string _userId;

        public BudgetServices(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;

            var userClaims = httpContextAccessor.HttpContext!.User.Identity as ClaimsIdentity;
            
            var value = userClaims!.Claims.FirstOrDefault();
            _userId = value!.Value;

            if (_userId == null)
                throw new Exception("User is not Signed In.");
        }

        public async Task<bool> CreateBudget(BudgetCreate model)
        {
            var budget = _mapper.Map<Budget>(model);
            budget.OwnerId = _userId;
            await _context.Budgets.AddAsync(budget); 
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBudget(int id)
        {
            var budget = await _context.Budgets.FindAsync(id);
            if(budget is null) return false;
            _context.Budgets.Remove(budget);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<BudgetDetail> GetBudget(int id)
        {
            var budget = await _context.Budgets
                .Include(b => b.Bills)
                .Include(i => i.Incomes)
                .Where(b => b.OwnerId == _userId)
                .SingleOrDefaultAsync(x  => x.Id == id);
            
            if(budget is null) return new BudgetDetail();

            if (budget?.OwnerId != _userId)
                return null!;

            return _mapper.Map<BudgetDetail>(budget);
        }

        public async Task<List<BudgetListItem>> GetBudgets()
        {
            var budgets = await _context.Budgets
                .Include(b => b.Bills)
                .Include(i => i.Incomes)
                .Where(b => b.OwnerId == _userId)
                .ToListAsync();

            foreach (var budget in budgets)
            {
                if(budget?.OwnerId != _userId)
                return null!;
            }

            var noOwnerId = budgets.Any(b => b.OwnerId != _userId);
            if (noOwnerId)
                return null!;
            else
            return _mapper.Map<List<BudgetListItem>>(budgets);
        }

        public async Task<bool> UpdateBudget(BudgetEdit model)
        {
            var budget = await _context.Budgets.FindAsync(model.Id);
            if(budget is null) return false;

            budget.Month = model.Month;
            budget.Year = model.Year;
            budget.AvailableFunds = model.AvailableFunds;
            await _context.SaveChangesAsync();

            return true;
        }

        
    }
}
