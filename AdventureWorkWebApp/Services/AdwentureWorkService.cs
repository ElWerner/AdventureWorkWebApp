using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorkWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorkWebApp.Services
{
    public class DimAccountService : IDimAccountService
    {
        private readonly AdventureWorksDW2012Context _context;

        public DimAccountService(AdventureWorksDW2012Context context)
        {
            _context = context;
        }

        public async Task AddDimCustomerAsync(DimAccount customer)
        {
            await _context.DimAccount.AddAsync(customer);

            await _context.SaveChangesAsync();
        }

        public async Task<DimAccount> GetDimCustomerByIdAsync(int id)
        {
            return await _context.DimAccount.FirstOrDefaultAsync(g => g.AccountKey == id).ConfigureAwait(true);
        }
    }
}
