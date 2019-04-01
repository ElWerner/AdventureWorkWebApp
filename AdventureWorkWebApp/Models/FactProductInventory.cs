using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class FactProductInventory
    {
        public int ProductKey { get; set; }
        public int DateKey { get; set; }
        public DateTime MovementDate { get; set; }
        public decimal UnitCost { get; set; }
        public int UnitsIn { get; set; }
        public int UnitsOut { get; set; }
        public int UnitsBalance { get; set; }

        public DimDate DateKeyNavigation { get; set; }
        public DimProduct ProductKeyNavigation { get; set; }
    }
}
