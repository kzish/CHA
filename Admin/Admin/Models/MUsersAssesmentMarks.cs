using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public partial class MUsersAssesmentMarks
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string MContinouseAssesmentIdFk { get; set; }
        public decimal Percentage { get; set; }

        public virtual MContinouseAssesment MContinouseAssesmentIdFkNavigation { get; set; }
    }
}
