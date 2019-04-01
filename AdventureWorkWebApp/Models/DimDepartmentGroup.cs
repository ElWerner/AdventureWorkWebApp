using System;
using System.Collections.Generic;

namespace AdventureWorkWebApp.Models
{
    public partial class DimDepartmentGroup
    {
        public DimDepartmentGroup()
        {
            InverseParentDepartmentGroupKeyNavigation = new HashSet<DimDepartmentGroup>();
        }

        public int DepartmentGroupKey { get; set; }
        public int? ParentDepartmentGroupKey { get; set; }
        public string DepartmentGroupName { get; set; }

        public DimDepartmentGroup ParentDepartmentGroupKeyNavigation { get; set; }
        public ICollection<DimDepartmentGroup> InverseParentDepartmentGroupKeyNavigation { get; set; }
    }
}
