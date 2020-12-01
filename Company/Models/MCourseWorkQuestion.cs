using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MCourseWorkQuestion
    {
        public MCourseWorkQuestion()
        {
            MCourseWorkQuestionAnswerOptions = new HashSet<MCourseWorkQuestionAnswerOptions>();
            MUsersAnswersCourseMaterial = new HashSet<MUsersAnswersCourseMaterial>();
        }

        public string Id { get; set; }
        public int QuestionSequence { get; set; }
        public string EQuestionTypeIdFk { get; set; }
        public string MCourseMaterialIdFk { get; set; }
        public string QuestionText { get; set; }

        public virtual EQuestionAnswerType EQuestionTypeIdFkNavigation { get; set; }
        public virtual MCourseMaterial MCourseMaterialIdFkNavigation { get; set; }
        public virtual ICollection<MCourseWorkQuestionAnswerOptions> MCourseWorkQuestionAnswerOptions { get; set; }
        public virtual ICollection<MUsersAnswersCourseMaterial> MUsersAnswersCourseMaterial { get; set; }
    }
}
