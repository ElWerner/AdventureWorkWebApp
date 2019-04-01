using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimSalesTerritory
    {
        public DimSalesTerritory()
        {
            DimEmployee = new HashSet<DimEmployee>();
            DimGeography = new HashSet<DimGeography>();
            FactInternetSales = new HashSet<FactInternetSales>();
            FactResellerSales = new HashSet<FactResellerSales>();
        }

        public int SalesTerritoryKey { get; set; }
        public int? SalesTerritoryAlternateKey { get; set; }
        public string SalesTerritoryRegion { get; set; }
        public string SalesTerritoryCountry { get; set; }
        public string SalesTerritoryGroup { get; set; }
        public byte[] SalesTerritoryImage { get; set; }

        public ICollection<DimEmployee> DimEmployee { get; set; }
        public ICollection<DimGeography> DimGeography { get; set; }
        public ICollection<FactInternetSales> FactInternetSales { get; set; }
        public ICollection<FactResellerSales> FactResellerSales { get; set; }
    }
}
