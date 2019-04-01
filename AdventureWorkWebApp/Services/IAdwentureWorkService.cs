using AdventureWorkWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorkWebApp.Services
{
    public interface IDimAccountService
    {
        Task<DimAccount> GetDimCustomerByIdAsync(int id);

        Task AddDimCustomerAsync(DimAccount customer);
    }
}
