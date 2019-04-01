using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimProductCategory
    {
        public DimProductCategory()
        {
            DimProductSubcategory = new HashSet<DimProductSubcategory>();
        }

        public int ProductCategoryKey { get; set; }
        public int? ProductCategoryAlternateKey { get; set; }
        public string EnglishProductCategoryName { get; set; }
        public string SpanishProductCategoryName { get; set; }
        public string FrenchProductCategoryName { get; set; }

        public ICollection<DimProductSubcategory> DimProductSubcategory { get; set; }
    }
}
