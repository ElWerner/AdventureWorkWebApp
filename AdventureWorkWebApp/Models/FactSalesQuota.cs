using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class FactSalesQuota
    {
        public int SalesQuotaKey { get; set; }
        public int EmployeeKey { get; set; }
        public int DateKey { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public decimal SalesAmountQuota { get; set; }
        public DateTime? Date { get; set; }

        public DimDate DateKeyNavigation { get; set; }
        public DimEmployee EmployeeKeyNavigation { get; set; }
    }
}
