using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MCourseWorkProgress
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string CourseIdFk { get; set; }
        public string CoursePageIdNfk { get; set; }
        public string TopicIdNfk { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse CourseIdFkNavigation { get; set; }
    }
}
