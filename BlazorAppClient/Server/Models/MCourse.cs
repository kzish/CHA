using System;
using System.Collections.Generic;

namespace BlazorAppClient.Server.Models
{
    public partial class MCourse
    {
        public MCourse()
        {
            MBoardGameUsersAnswers = new HashSet<MBoardGameUsersAnswers>();
            MContinouseAssesment = new HashSet<MContinouseAssesment>();
            MCourseExamReports = new HashSet<MCourseExamReports>();
            MCourseInstructor = new HashSet<MCourseInstructor>();
            MCourseMaterial = new HashSet<MCourseMaterial>();
            MCourseObjectives = new HashSet<MCourseObjectives>();
            MCourseStartAndStopTime = new HashSet<MCourseStartAndStopTime>();
            MCourseTakers = new HashSet<MCourseTakers>();
            MCourseTopic = new HashSet<MCourseTopic>();
            MCourseWorkProgress = new HashSet<MCourseWorkProgress>();
            MQuestion = new HashSet<MQuestion>();
            MQuestionAnswerOptions = new HashSet<MQuestionAnswerOptions>();
            MUsersAnswers = new HashSet<MUsersAnswers>();
        }

        public string Id { get; set; }
        public string CourseName { get; set; }
        public string ECourseCategoryIdFk { get; set; }
        public string CreatedByAspNetUserIdFk { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Published { get; set; }
        public DateTime? DatePublished { get; set; }
        public int? CourseDurationHours { get; set; }
        public int? CourseStudyTimeHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CourseDescription { get; set; }
        public string CourseAudience { get; set; }
        public string CourseObjectives { get; set; }

        public virtual AspNetUsers CreatedByAspNetUserIdFkNavigation { get; set; }
        public virtual ECourseCategory ECourseCategoryIdFkNavigation { get; set; }
        public virtual ICollection<MBoardGameUsersAnswers> MBoardGameUsersAnswers { get; set; }
        public virtual ICollection<MContinouseAssesment> MContinouseAssesment { get; set; }
        public virtual ICollection<MCourseExamReports> MCourseExamReports { get; set; }
        public virtual ICollection<MCourseInstructor> MCourseInstructor { get; set; }
        public virtual ICollection<MCourseMaterial> MCourseMaterial { get; set; }
        public virtual ICollection<MCourseObjectives> MCourseObjectives { get; set; }
        public virtual ICollection<MCourseStartAndStopTime> MCourseStartAndStopTime { get; set; }
        public virtual ICollection<MCourseTakers> MCourseTakers { get; set; }
        public virtual ICollection<MCourseTopic> MCourseTopic { get; set; }
        public virtual ICollection<MCourseWorkProgress> MCourseWorkProgress { get; set; }
        public virtual ICollection<MQuestion> MQuestion { get; set; }
        public virtual ICollection<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
        public virtual ICollection<MUsersAnswers> MUsersAnswers { get; set; }
    }
}
