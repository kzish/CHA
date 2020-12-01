using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MCourseExamReports
    {
        public string Id { get; set; }
        public string CourseIdFk { get; set; }
        public string AspNetUserIdFk { get; set; }
        public DateTime ExamStartDate { get; set; }
        public DateTime? ExamEndDate { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse CourseIdFkNavigation { get; set; }
    }
}
