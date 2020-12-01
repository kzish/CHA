using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class MCourseMaterial
    {
        public MCourseMaterial()
        {
            MBoardGameUsersAnswers = new HashSet<MBoardGameUsersAnswers>();
            MCourseWorkQuestion = new HashSet<MCourseWorkQuestion>();
        }

        public string Id { get; set; }
        public string MCourseIdFk { get; set; }
        public string MCourseTopicIdNfk { get; set; }
        public int PageSequence { get; set; }
        public string PageData { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Published { get; set; }
        public DateTime? DatePublished { get; set; }
        public string PageTitle { get; set; }
        public bool HasQuestions { get; set; }
        public bool HasBoardGame { get; set; }

        public virtual MCourse MCourseIdFkNavigation { get; set; }
        public virtual ICollection<MBoardGameUsersAnswers> MBoardGameUsersAnswers { get; set; }
        public virtual ICollection<MCourseWorkQuestion> MCourseWorkQuestion { get; set; }
    }
}
