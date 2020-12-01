using System;
using System.Collections.Generic;

namespace Company.Models
{
    public partial class MUsersAnswers
    {
        public string Id { get; set; }
        public string AspNetUserIdFk { get; set; }
        public string QuestionIdFk { get; set; }
        public string CourseIdNfk { get; set; }
        public string TopicIdNfk { get; set; }
        public DateTime DateAnswered { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MQuestion QuestionIdFkNavigation { get; set; }
    }
}
