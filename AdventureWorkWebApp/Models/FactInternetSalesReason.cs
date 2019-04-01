using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class FactInternetSalesReason
    {
        public string SalesOrderNumber { get; set; }
        public byte SalesOrderLineNumber { get; set; }
        public int SalesReasonKey { get; set; }

        public FactInternetSales SalesOrder { get; set; }
        public DimSalesReason SalesReasonKeyNavigation { get; set; }
    }
}
