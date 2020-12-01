using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MCourseInstructor
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string MCourseIdFk { get; set; }
    }
}
