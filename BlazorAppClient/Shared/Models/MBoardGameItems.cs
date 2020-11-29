using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MBoardGameItems
    {
        public string Id { get; set; }
        public string MBoardGameIdFk { get; set; }
        public string ItemText { get; set; }
        public string CorrectTitleIdFk { get; set; }

        public virtual MBoardGame MBoardGameIdFkNavigation { get; set; }
    }
}
