using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimCurrency
    {
        public DimCurrency()
        {
            DimOrganization = new HashSet<DimOrganization>();
            FactCurrencyRate = new HashSet<FactCurrencyRate>();
            FactInternetSales = new HashSet<FactInternetSales>();
            FactResellerSales = new HashSet<FactResellerSales>();
        }

        public int CurrencyKey { get; set; }
        public string CurrencyAlternateKey { get; set; }
        public string CurrencyName { get; set; }

        public ICollection<DimOrganization> DimOrganization { get; set; }
        public ICollection<FactCurrencyRate> FactCurrencyRate { get; set; }
        public ICollection<FactInternetSales> FactInternetSales { get; set; }
        public ICollection<FactResellerSales> FactResellerSales { get; set; }
    }
}
