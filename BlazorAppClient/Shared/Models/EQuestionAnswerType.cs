using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class EQuestionAnswerType
    {
        public EQuestionAnswerType()
        {
            MQuestion = new HashSet<MQuestion>();
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<MQuestion> MQuestion { get; set; }
    }
}
