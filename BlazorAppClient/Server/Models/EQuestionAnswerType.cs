using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class EQuestionAnswerType
    {
        public EQuestionAnswerType()
        {
            MCourseWorkQuestion = new HashSet<MCourseWorkQuestion>();
            MQuestion = new HashSet<MQuestion>();
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<MCourseWorkQuestion> MCourseWorkQuestion { get; set; }
        public virtual ICollection<MQuestion> MQuestion { get; set; }
    }
}
