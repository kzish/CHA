﻿using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MBoardGameUsersAnswers
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string MCourseMaterialIdFk { get; set; }
        public string MCourseIdFk { get; set; }
        public string JsonAnswer { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse MCourseIdFkNavigation { get; set; }
    }
}
