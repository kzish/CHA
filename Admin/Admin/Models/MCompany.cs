using System;
using System.Collections.Generic;

namespace Admin.Models
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
