using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class FactSurveyResponse
    {
        public int SurveyResponseKey { get; set; }
        public int DateKey { get; set; }
        public int CustomerKey { get; set; }
        public int ProductCategoryKey { get; set; }
        public string EnglishProductCategoryName { get; set; }
        public int ProductSubcategoryKey { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
        public DateTime? Date { get; set; }

        public DimCustomer CustomerKeyNavigation { get; set; }
        public DimDate DateKeyNavigation { get; set; }
    }
}
