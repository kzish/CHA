﻿using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MCourseTakers
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string CourseIdFk { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse CourseIdFkNavigation { get; set; }
    }
}
