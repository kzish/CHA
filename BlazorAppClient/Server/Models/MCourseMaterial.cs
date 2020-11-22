using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MCourseMaterial
    {
        public MCourseMaterial()
        {
            MCourseWorkQuestion = new HashSet<MCourseWorkQuestion>();
            MUsersAnswersCourseMaterial = new HashSet<MUsersAnswersCourseMaterial>();
        }

        public string Id { get; set; }
        public string MCourseIdFk { get; set; }
        public string MCourseTopicIdFk { get; set; }
        public int PageSequence { get; set; }
        public string PageData { get; set; }
        public string CreatedByAspNetUserIdFk { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Published { get; set; }
        public DateTime? DatePublished { get; set; }
        public string PageTitle { get; set; }
        public bool HasQuestions { get; set; }

        public virtual AspNetUsers CreatedByAspNetUserIdFkNavigation { get; set; }
        public virtual MCourse MCourseIdFkNavigation { get; set; }
        public virtual MCourseTopic MCourseTopicIdFkNavigation { get; set; }
        public virtual ICollection<MCourseWorkQuestion> MCourseWorkQuestion { get; set; }
        public virtual ICollection<MUsersAnswersCourseMaterial> MUsersAnswersCourseMaterial { get; set; }
    }
}
