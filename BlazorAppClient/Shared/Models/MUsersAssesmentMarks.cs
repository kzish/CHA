using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MUsersAssesmentMarks
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string MContinouseAssesmentIdFk { get; set; }
        public decimal Percentage { get; set; }
        public string Comments { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MContinouseAssesment MContinouseAssesmentIdFkNavigation { get; set; }
    }
}
