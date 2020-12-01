using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MCourseWorkQuestionAnswerOptions
    {
        public string Id { get; set; }
        public string MCourseWorkQuestionIdFk { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public string Explanation { get; set; }

        public virtual MCourseWorkQuestion MCourseWorkQuestionIdFkNavigation { get; set; }
    }
}
