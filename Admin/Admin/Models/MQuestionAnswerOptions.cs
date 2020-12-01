﻿using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class MQuestionAnswerOptions
    {
        public string Id { get; set; }
        public string MQuestionIdFk { get; set; }
        public string MCourseIdNfk { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public string Explanation { get; set; }

        public virtual MQuestion MQuestionIdFkNavigation { get; set; }
    }
}
