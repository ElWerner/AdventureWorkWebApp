using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimOrganization
    {
        public DimOrganization()
        {
            InverseParentOrganizationKeyNavigation = new HashSet<DimOrganization>();
        }

        public int OrganizationKey { get; set; }
        public int? ParentOrganizationKey { get; set; }
        public string PercentageOfOwnership { get; set; }
        public string OrganizationName { get; set; }
        public int? CurrencyKey { get; set; }

        public DimCurrency CurrencyKeyNavigation { get; set; }
        public DimOrganization ParentOrganizationKeyNavigation { get; set; }
        public ICollection<DimOrganization> InverseParentOrganizationKeyNavigation { get; set; }
    }
}
