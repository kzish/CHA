﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorAppClient.Server.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<ECourseCategory> ECourseCategory { get; set; }
        public virtual DbSet<EQuestionAnswerType> EQuestionAnswerType { get; set; }
        public virtual DbSet<MCompany> MCompany { get; set; }
        public virtual DbSet<MCourse> MCourse { get; set; }
        public virtual DbSet<MCourseInstructor> MCourseInstructor { get; set; }
        public virtual DbSet<MCourseMaterial> MCourseMaterial { get; set; }
        public virtual DbSet<MCourseObjectives> MCourseObjectives { get; set; }
        public virtual DbSet<MCourseTakers> MCourseTakers { get; set; }
        public virtual DbSet<MCourseTopic> MCourseTopic { get; set; }
        public virtual DbSet<MMedia> MMedia { get; set; }
        public virtual DbSet<MQuestion> MQuestion { get; set; }
        public virtual DbSet<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
        public virtual DbSet<MUsersAnswers> MUsersAnswers { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.;user id=sa;password=Password#99;database=CHA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.MCompanyIdFk)
                    .HasColumnName("m_company_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("user may be associated with a company");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.MCompanyIdFkNavigation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.MCompanyIdFk)
                    .HasConstraintName("FK_AspNetUsers_m_company");
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<ECourseCategory>(entity =>
            {
                entity.ToTable("e_course_category");

                entity.HasComment("the category for the cources, set by the admin");

                entity.HasIndex(e => e.Category)
                    .HasName("unique_category")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("the name of the category of the course");
            });

            modelBuilder.Entity<EQuestionAnswerType>(entity =>
            {
                entity.ToTable("e_question_answer_type");

                entity.HasComment(@"the type of the question's answer, 
ie will the answer be 
radio buttons,
check boxes,
text,");

                entity.HasIndex(e => e.Type)
                    .HasName("unique_type")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("the type of the response the questions will expect, are they check boxes, radio buttons, or text");
            });

            modelBuilder.Entity<MCompany>(entity =>
            {
                entity.ToTable("m_company");

                entity.HasComment(@"model of a company
users may be assosiated to a company
each company has a default company admin
company admin  will manage his own users
");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("unique_company_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCourse>(entity =>
            {
                entity.ToTable("m_course");

                entity.HasComment("the model of the course");

                entity.HasIndex(e => e.CourseName)
                    .HasName("unique_course_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseAudience)
                    .HasColumnName("course_audience")
                    .IsUnicode(false);

                entity.Property(e => e.CourseDescription)
                    .HasColumnName("course_description")
                    .IsUnicode(false);

                entity.Property(e => e.CourseDurationHours).HasColumnName("course_duration_hours");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("course_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name given to this course");

                entity.Property(e => e.CourseObjectives)
                    .HasColumnName("course_objectives")
                    .IsUnicode(false);

                entity.Property(e => e.CourseStudyTimeHours).HasColumnName("course_study_time_hours");

                entity.Property(e => e.CreatedByAspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("created_by_asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("date_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECourseCategoryIdFk)
                    .IsRequired()
                    .HasColumnName("e_course_category_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the e_cour");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByAspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourse)
                    .HasForeignKey(d => d.CreatedByAspNetUserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_AspNetUsers");

                entity.HasOne(d => d.ECourseCategoryIdFkNavigation)
                    .WithMany(p => p.MCourse)
                    .HasForeignKey(d => d.ECourseCategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_e_course_category");
            });

            modelBuilder.Entity<MCourseInstructor>(entity =>
            {
                entity.ToTable("m_course_instructor");

                entity.HasComment("course instructor model");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450)
                    .HasComment("links to the aspnetuser who is the instructor");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course this instructor is taking/assigned");

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseInstructor)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_intructor_AspNetUsers");

                entity.HasOne(d => d.MCourseIdFkNavigation)
                    .WithMany(p => p.MCourseInstructor)
                    .HasForeignKey(d => d.MCourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_instructor_m_course");
            });

            modelBuilder.Entity<MCourseMaterial>(entity =>
            {
                entity.ToTable("m_course_material");

                entity.HasComment(@"model the course material,
this is an actual page of the course work
sequencing by page numbers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedByAspNetUserIdFk)
                    .HasColumnName("created_by_asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("date_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course");

                entity.Property(e => e.MCourseTopicIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course topic");

                entity.Property(e => e.PageData)
                    .IsRequired()
                    .HasColumnName("page_data")
                    .IsUnicode(false)
                    .HasComment(@"html to be rendered
images, audio, video will be rendered and will have extra parameters to help render");

                entity.Property(e => e.PageSequence)
                    .HasColumnName("page_sequence")
                    .HasComment("the sequence this page must appear");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnName("page_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Published).HasColumnName("published");

                entity.HasOne(d => d.CreatedByAspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseMaterial)
                    .HasForeignKey(d => d.CreatedByAspNetUserIdFk)
                    .HasConstraintName("FK_m_course_material_AspNetUsers");

                entity.HasOne(d => d.MCourseIdFkNavigation)
                    .WithMany(p => p.MCourseMaterial)
                    .HasForeignKey(d => d.MCourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_material_m_course");

                entity.HasOne(d => d.MCourseTopicIdFkNavigation)
                    .WithMany(p => p.MCourseMaterial)
                    .HasForeignKey(d => d.MCourseTopicIdFk)
                    .HasConstraintName("FK_m_course_material_m_course_topic");
            });

            modelBuilder.Entity<MCourseObjectives>(entity =>
            {
                entity.ToTable("m_course_objectives");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseIdFk)
                    .HasColumnName("course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Objective)
                    .HasColumnName("objective")
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseObjectives)
                    .HasForeignKey(d => d.CourseIdFk)
                    .HasConstraintName("FK_m_course_objectives_m_course");
            });

            modelBuilder.Entity<MCourseTakers>(entity =>
            {
                entity.ToTable("m_course_takers");

                entity.HasComment("which users are taking which courses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.CourseIdFk)
                    .IsRequired()
                    .HasColumnName("course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseTakers)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .HasConstraintName("FK_m_course_takers_AspNetUsers");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseTakers)
                    .HasForeignKey(d => d.CourseIdFk)
                    .HasConstraintName("FK_m_course_takers_m_course");
            });

            modelBuilder.Entity<MCourseTopic>(entity =>
            {
                entity.ToTable("m_course_topic");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseIdFk)
                    .IsRequired()
                    .HasColumnName("course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course this topic is under");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name of the topic under this course");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseTopic)
                    .HasForeignKey(d => d.CourseIdFk)
                    .HasConstraintName("FK_m_course_topic_m_course");
            });

            modelBuilder.Entity<MMedia>(entity =>
            {
                entity.HasKey(e => e.IdFileNameGuid);

                entity.ToTable("m_media");

                entity.HasComment(@"model for the media,
image
video
audio
file pdf doc etc

since all media is uploaded independantly it can be shared and reused in several places, saving disk space");

                entity.Property(e => e.IdFileNameGuid)
                    .HasColumnName("id_file_name_guid")
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("file_ guid, and file name and path on saving to disk");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasColumnName("original_file_name")
                    .IsUnicode(false)
                    .HasComment("original file name from the client on uploading");
            });

            modelBuilder.Entity<MQuestion>(entity =>
            {
                entity.ToTable("m_question");

                entity.HasComment("question model");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EQuestionTypeIdFk)
                    .IsRequired()
                    .HasColumnName("e_question_type_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the question type");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course");

                entity.Property(e => e.MCourseTopicIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the topic this question is under");

                entity.Property(e => e.QuestionSequence)
                    .HasColumnName("question_sequence")
                    .HasComment("order you want the question to appear");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnName("question_text")
                    .IsUnicode(false)
                    .HasComment("this will be html content rendered onto the screen, videos and audio will have extra paraeters to help render the content");

                entity.HasOne(d => d.EQuestionTypeIdFkNavigation)
                    .WithMany(p => p.MQuestion)
                    .HasForeignKey(d => d.EQuestionTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_question_e_question_type");

                entity.HasOne(d => d.MCourseIdFkNavigation)
                    .WithMany(p => p.MQuestion)
                    .HasForeignKey(d => d.MCourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_question_m_course");

                entity.HasOne(d => d.MCourseTopicIdFkNavigation)
                    .WithMany(p => p.MQuestion)
                    .HasForeignKey(d => d.MCourseTopicIdFk)
                    .HasConstraintName("FK_m_question_m_course_topic");
            });

            modelBuilder.Entity<MQuestionAnswerOptions>(entity =>
            {
                entity.ToTable("m_question_answer_options");

                entity.HasComment(@"this is the model of the answers for the questions

each question type will be rendered in its own way");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsCorrectAnswer).HasColumnName("is_correct_answer");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the course");

                entity.Property(e => e.MQuestionIdFk)
                    .IsRequired()
                    .HasColumnName("m_question_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the question");

                entity.Property(e => e.OptionText)
                    .IsRequired()
                    .HasColumnName("option_text")
                    .IsUnicode(false);

                entity.HasOne(d => d.MCourseIdFkNavigation)
                    .WithMany(p => p.MQuestionAnswerOptions)
                    .HasForeignKey(d => d.MCourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_question_answer_options_m_course");

                entity.HasOne(d => d.MQuestionIdFkNavigation)
                    .WithMany(p => p.MQuestionAnswerOptions)
                    .HasForeignKey(d => d.MQuestionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_question_answer_options_m_question");
            });

            modelBuilder.Entity<MUsersAnswers>(entity =>
            {
                entity.ToTable("m_users_answers");

                entity.HasComment("the answeres to the questions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("answer")
                    .IsUnicode(false);

                entity.Property(e => e.AspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");

                entity.Property(e => e.CourseIdFk)
                    .IsRequired()
                    .HasColumnName("course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAnswered)
                    .HasColumnName("date_answered")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuestionIdFk)
                    .IsRequired()
                    .HasColumnName("question_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopicIdFk)
                    .IsRequired()
                    .HasColumnName("topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MUsersAnswers)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_users_answers_AspNetUsers");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MUsersAnswers)
                    .HasForeignKey(d => d.CourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_users_answers_m_course");

                entity.HasOne(d => d.QuestionIdFkNavigation)
                    .WithMany(p => p.MUsersAnswers)
                    .HasForeignKey(d => d.QuestionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_users_answers_m_question");

                entity.HasOne(d => d.TopicIdFkNavigation)
                    .WithMany(p => p.MUsersAnswers)
                    .HasForeignKey(d => d.TopicIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_users_answers_m_course_topic");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
