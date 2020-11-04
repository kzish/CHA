using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class ECourseCategory
    {
        public ECourseCategory()
        {
            MCourse = new HashSet<MCourse>();
        }

        public string Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<MCourse> MCourse { get; set; }
    }
}
