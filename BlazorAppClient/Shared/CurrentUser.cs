using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppClient.Shared
{
    /// <summary>
    /// represents the current logged in user
    /// </summary>
    public class CurrentUser
    {
        public string user_id { get; set; }
        public string company_id { get; set; }
        public string company_name { get; set; }
    }
}
