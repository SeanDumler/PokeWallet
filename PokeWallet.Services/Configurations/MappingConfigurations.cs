using AutoMapper;
using PokeWallet.Data.Entities;
using PokeWallet.Models.BillModels;
using PokeWallet.Models.BudgetModels;
using PokeWallet.Models.IncomeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWallet.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Bill, BillCreate>().ReverseMap();
            CreateMap<Bill, BillListItem>().ReverseMap();
            CreateMap<Bill, BillDetail>().ReverseMap();
            CreateMap<Bill, BillEdit>().ReverseMap();

            CreateMap<Income, IncomeCreate>().ReverseMap();
            CreateMap<Income, IncomeListItem>().ReverseMap();
            CreateMap<Income, IncomeDetail>().ReverseMap();
            CreateMap<Income, IncomeEdit>().ReverseMap();

            CreateMap<Budget, BudgetCreate>().ReverseMap();
            CreateMap<Budget, BudgetListItem>().ReverseMap();
            CreateMap<Budget, BudgetDetail>().ReverseMap();
        }
    }
}
