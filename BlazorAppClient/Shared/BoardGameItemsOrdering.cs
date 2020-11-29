using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppClient.Shared
{

    //this class groups the title id and the items id when rendered and ordered by the student
    //this will be compared to the original from the server
    public class BoardGameItemsOrdering
    {
        public string title_id { get; set; }
        public List<string> item_ids { get; set; } = new List<string>();
    }
}
