using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimSalesReason
    {
        public DimSalesReason()
        {
            FactInternetSalesReason = new HashSet<FactInternetSalesReason>();
        }

        public int SalesReasonKey { get; set; }
        public int SalesReasonAlternateKey { get; set; }
        public string SalesReasonName { get; set; }
        public string SalesReasonReasonType { get; set; }

        public ICollection<FactInternetSalesReason> FactInternetSalesReason { get; set; }
    }
}
