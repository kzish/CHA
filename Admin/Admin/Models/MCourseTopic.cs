using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class MCourseTopic
    {
        public MCourseTopic()
        {
            MCourseMaterial = new HashSet<MCourseMaterial>();
            MQuestion = new HashSet<MQuestion>();
            MQuestionAnswerOptions = new HashSet<MQuestionAnswerOptions>();
        }

        public string Id { get; set; }
        public string CourseIdFk { get; set; }
        public string Topic { get; set; }
        public int Sequence { get; set; }

        public virtual MCourse CourseIdFkNavigation { get; set; }
        public virtual ICollection<MCourseMaterial> MCourseMaterial { get; set; }
        public virtual ICollection<MQuestion> MQuestion { get; set; }
        public virtual ICollection<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
    }
}
