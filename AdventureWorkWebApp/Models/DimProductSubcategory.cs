using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimProductSubcategory
    {
        public DimProductSubcategory()
        {
            DimProduct = new HashSet<DimProduct>();
        }

        public int ProductSubcategoryKey { get; set; }
        public int? ProductSubcategoryAlternateKey { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
        public string SpanishProductSubcategoryName { get; set; }
        public string FrenchProductSubcategoryName { get; set; }
        public int? ProductCategoryKey { get; set; }

        public DimProductCategory ProductCategoryKeyNavigation { get; set; }
        public ICollection<DimProduct> DimProduct { get; set; }
    }
}
