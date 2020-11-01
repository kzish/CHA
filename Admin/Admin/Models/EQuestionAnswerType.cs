using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class EQuestionAnswerType
    {
        public EQuestionAnswerType()
        {
            MQuestion = new HashSet<MQuestion>();
            MQuestionAnswerOptions = new HashSet<MQuestionAnswerOptions>();
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<MQuestion> MQuestion { get; set; }
        public virtual ICollection<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
    }
}
