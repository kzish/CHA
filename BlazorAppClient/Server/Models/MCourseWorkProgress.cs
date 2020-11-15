using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MCourseWorkProgress
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string CourseIdFk { get; set; }
        public string CoursePageIdFk { get; set; }
        public string TopicIdFk { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse CourseIdFkNavigation { get; set; }
        public virtual MCourseTopic TopicIdFkNavigation { get; set; }
    }
}
