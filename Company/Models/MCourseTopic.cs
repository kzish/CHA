using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MCourseTopic
    {
        public string Id { get; set; }
        public string CourseIdFk { get; set; }
        public string Topic { get; set; }
        public int Sequence { get; set; }

        public virtual MCourse CourseIdFkNavigation { get; set; }
    }
}
