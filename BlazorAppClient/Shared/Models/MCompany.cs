using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MCompany
    {
        public MCompany()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public string Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
