using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MUsersAnswers
    {
        public string Id { get; set; }
        public string CourseIdFk { get; set; }
        public string TopicIdFk { get; set; }
        public string QuestionIdFk { get; set; }
        public string AspNetUserIdFk { get; set; }
        public DateTime DateAnswered { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual AspNetUsers AspNetUserIdFkNavigation { get; set; }
        public virtual MCourse CourseIdFkNavigation { get; set; }
        public virtual MQuestion QuestionIdFkNavigation { get; set; }
        public virtual MCourseTopic TopicIdFkNavigation { get; set; }
    }
}
