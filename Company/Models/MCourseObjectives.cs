﻿using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MCourseObjectives
    {
        public string Id { get; set; }
        public string CourseIdFk { get; set; }
        public string Objective { get; set; }

        public virtual MCourse CourseIdFkNavigation { get; set; }
    }
}
