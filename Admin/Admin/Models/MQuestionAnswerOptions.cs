﻿using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class MQuestionAnswerOptions
    {
        public string Id { get; set; }
        public string EQuestionAnswerTypeIdFk { get; set; }
        public string MCourseIdFk { get; set; }
        public string MCourseTopicIdFk { get; set; }
        public string MQuestionIdFk { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrectAnswer { get; set; }

        public virtual EQuestionAnswerType EQuestionAnswerTypeIdFkNavigation { get; set; }
        public virtual MCourse MCourseIdFkNavigation { get; set; }
        public virtual MCourseTopic MCourseTopicIdFkNavigation { get; set; }
        public virtual MQuestion MQuestionIdFkNavigation { get; set; }
    }
}
