using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class MUsersAnswersCourseMaterial
    {
        public string Id { get; set; }
        public string CourseMaterialIdFk { get; set; }
        public string AspNetUserIdFk { get; set; }
        public DateTime DateAnswered { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }
        public string CourseMaterialQuestionIdFk { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourseMaterial CourseMaterialIdFkNavigation { get; set; }
        public virtual MCourseWorkQuestion CourseMaterialQuestionIdFkNavigation { get; set; }
    }
}
