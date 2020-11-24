using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class MContinouseAssesment
    {
        public MContinouseAssesment()
        {
            MUsersAssesmentMarks = new HashSet<MUsersAssesmentMarks>();
        }

        public string Id { get; set; }
        public string AssesmentName { get; set; }
        public string Description { get; set; }
        public string MCourseIdFk { get; set; }

        public virtual MCourse MCourseIdFkNavigation { get; set; }
        public virtual ICollection<MUsersAssesmentMarks> MUsersAssesmentMarks { get; set; }
    }
}
