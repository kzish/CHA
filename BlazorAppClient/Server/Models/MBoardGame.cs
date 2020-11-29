using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MBoardGame
    {
        public MBoardGame()
        {
            MBoardGameItems = new HashSet<MBoardGameItems>();
            MBoardGameTitles = new HashSet<MBoardGameTitles>();
        }

        public string Id { get; set; }
        public string CourseMaterialIdFk { get; set; }

        public virtual ICollection<MBoardGameItems> MBoardGameItems { get; set; }
        public virtual ICollection<MBoardGameTitles> MBoardGameTitles { get; set; }
    }
}
