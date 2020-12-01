using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MQuestion
    {
        public MQuestion()
        {
            MQuestionAnswerOptions = new HashSet<MQuestionAnswerOptions>();
            MUsersAnswers = new HashSet<MUsersAnswers>();
        }

        public string Id { get; set; }
        public string EQuestionTypeIdFk { get; set; }
        public string MCourseIdFk { get; set; }
        public string MCourseTopicIdNfk { get; set; }
        public int QuestionSequence { get; set; }
        public string QuestionText { get; set; }

        public virtual EQuestionAnswerType EQuestionTypeIdFkNavigation { get; set; }
        public virtual MCourse MCourseIdFkNavigation { get; set; }
        public virtual ICollection<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
        public virtual ICollection<MUsersAnswers> MUsersAnswers { get; set; }
    }
}
