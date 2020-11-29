﻿using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MBoardGameTitles
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string MBoardGameIdFk { get; set; }

        public virtual MBoardGame MBoardGameIdFkNavigation { get; set; }
    }
}