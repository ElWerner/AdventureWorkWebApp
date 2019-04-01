using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class FactCurrencyRate
    {
        public int CurrencyKey { get; set; }
        public int DateKey { get; set; }
        public double AverageRate { get; set; }
        public double EndOfDayRate { get; set; }
        public DateTime? Date { get; set; }

        public DimCurrency CurrencyKeyNavigation { get; set; }
        public DimDate DateKeyNavigation { get; set; }
    }
}
