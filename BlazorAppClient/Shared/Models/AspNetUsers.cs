using System;
using System.Collections.Generic;

namespace BlazorAppClient.Shared.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            MBoardGameUsersAnswers = new HashSet<MBoardGameUsersAnswers>();
            MCourse = new HashSet<MCourse>();
            MCourseExamReports = new HashSet<MCourseExamReports>();
            MCourseInstructor = new HashSet<MCourseInstructor>();
            MCourseMaterial = new HashSet<MCourseMaterial>();
            MCourseStartAndStopTime = new HashSet<MCourseStartAndStopTime>();
            MCourseTakers = new HashSet<MCourseTakers>();
            MCourseWorkProgress = new HashSet<MCourseWorkProgress>();
            MUsersAnswers = new HashSet<MUsersAnswers>();
            MUsersAnswersCourseMaterial = new HashSet<MUsersAnswersCourseMaterial>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string MCompanyIdFk { get; set; }

        public virtual MCompany MCompanyIdFkNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<MBoardGameUsersAnswers> MBoardGameUsersAnswers { get; set; }
        public virtual ICollection<MCourse> MCourse { get; set; }
        public virtual ICollection<MCourseExamReports> MCourseExamReports { get; set; }
        public virtual ICollection<MCourseInstructor> MCourseInstructor { get; set; }
        public virtual ICollection<MCourseMaterial> MCourseMaterial { get; set; }
        public virtual ICollection<MCourseStartAndStopTime> MCourseStartAndStopTime { get; set; }
        public virtual ICollection<MCourseTakers> MCourseTakers { get; set; }
        public virtual ICollection<MCourseWorkProgress> MCourseWorkProgress { get; set; }
        public virtual ICollection<MUsersAnswers> MUsersAnswers { get; set; }
        public virtual ICollection<MUsersAnswersCourseMaterial> MUsersAnswersCourseMaterial { get; set; }
    }
}
