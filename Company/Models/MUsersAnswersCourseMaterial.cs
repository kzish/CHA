using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MUsersAnswersCourseMaterial
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string CourseMaterialQuestionIdFk { get; set; }
        public string CourseMaterialIdNfk { get; set; }
        public DateTime DateAnswered { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourseWorkQuestion CourseMaterialQuestionIdFkNavigation { get; set; }
    }
}
