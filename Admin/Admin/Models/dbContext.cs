using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Admin.Models
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
        public virtual DbSet<MBoardGame> MBoardGame { get; set; }
        public virtual DbSet<MBoardGameItems> MBoardGameItems { get; set; }
        public virtual DbSet<MBoardGameTitles> MBoardGameTitles { get; set; }
        public virtual DbSet<MCompany> MCompany { get; set; }
        public virtual DbSet<MContinouseAssesment> MContinouseAssesment { get; set; }
        public virtual DbSet<MCourse> MCourse { get; set; }
        public virtual DbSet<MCourseExamReports> MCourseExamReports { get; set; }
        public virtual DbSet<MCourseInstructor> MCourseInstructor { get; set; }
        public virtual DbSet<MCourseMaterial> MCourseMaterial { get; set; }
        public virtual DbSet<MCourseObjectives> MCourseObjectives { get; set; }
        public virtual DbSet<MCourseStartAndStopTime> MCourseStartAndStopTime { get; set; }
        public virtual DbSet<MCourseTakers> MCourseTakers { get; set; }
        public virtual DbSet<MCourseTopic> MCourseTopic { get; set; }
        public virtual DbSet<MCourseWorkProgress> MCourseWorkProgress { get; set; }
        public virtual DbSet<MCourseWorkQuestion> MCourseWorkQuestion { get; set; }
        public virtual DbSet<MCourseWorkQuestionAnswerOptions> MCourseWorkQuestionAnswerOptions { get; set; }
        public virtual DbSet<MMedia> MMedia { get; set; }
        public virtual DbSet<MQuestion> MQuestion { get; set; }
        public virtual DbSet<MQuestionAnswerOptions> MQuestionAnswerOptions { get; set; }
        public virtual DbSet<MUsersAnswers> MUsersAnswers { get; set; }
        public virtual DbSet<MUsersAnswersCourseMaterial> MUsersAnswersCourseMaterial { get; set; }
        public virtual DbSet<MUsersAssesmentMarks> MUsersAssesmentMarks { get; set; }
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
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

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

                entity.Property(e => e.Id).ValueGeneratedNever();

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

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.MCompanyIdFk)
                    .HasColumnName("m_company_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.UserCode)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

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
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EQuestionAnswerType>(entity =>
            {
                entity.ToTable("e_question_answer_type");

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
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MBoardGame>(entity =>
            {
                entity.ToTable("m_board_game");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseMaterialIdFk)
                    .IsRequired()
                    .HasColumnName("course_material_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MBoardGameItems>(entity =>
            {
                entity.ToTable("m_board_game_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CorrectTitleIdFk)
                    .IsRequired()
                    .HasColumnName("correct_title_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemText)
                    .IsRequired()
                    .HasColumnName("item_text")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.MBoardGameIdFk)
                    .IsRequired()
                    .HasColumnName("m_board_game_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MBoardGameIdFkNavigation)
                    .WithMany(p => p.MBoardGameItems)
                    .HasForeignKey(d => d.MBoardGameIdFk)
                    .HasConstraintName("FK_m_board_game_items_m_board_game");
            });

            modelBuilder.Entity<MBoardGameTitles>(entity =>
            {
                entity.ToTable("m_board_game_titles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MBoardGameIdFk)
                    .IsRequired()
                    .HasColumnName("m_board_game_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.MBoardGameIdFkNavigation)
                    .WithMany(p => p.MBoardGameTitles)
                    .HasForeignKey(d => d.MBoardGameIdFk)
                    .HasConstraintName("FK_m_board_game_titles_m_board_game");
            });

            modelBuilder.Entity<MCompany>(entity =>
            {
                entity.ToTable("m_company");

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

            modelBuilder.Entity<MContinouseAssesment>(entity =>
            {
                entity.ToTable("m_continouse_assesment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssesmentName)
                    .IsRequired()
                    .HasColumnName("assesment_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MCourseIdFkNavigation)
                    .WithMany(p => p.MContinouseAssesment)
                    .HasForeignKey(d => d.MCourseIdFk)
                    .HasConstraintName("FK_m_continouse_assesment_m_course");
            });

            modelBuilder.Entity<MCourse>(entity =>
            {
                entity.ToTable("m_course");

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
                    .IsUnicode(false);

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
                    .IsUnicode(false);

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

            modelBuilder.Entity<MCourseExamReports>(entity =>
            {
                entity.ToTable("m_course_exam_reports");

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

                entity.Property(e => e.ExamEndDate)
                    .HasColumnName("exam_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExamStartDate)
                    .HasColumnName("exam_start_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseExamReports)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_exam_reports_AspNetUsers");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseExamReports)
                    .HasForeignKey(d => d.CourseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_course_exam_reports_m_course");
            });

            modelBuilder.Entity<MCourseInstructor>(entity =>
            {
                entity.ToTable("m_course_instructor");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.HasBoardGame).HasColumnName("has_board_game");

                entity.Property(e => e.HasQuestions).HasColumnName("has_questions");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCourseTopicIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageData)
                    .IsRequired()
                    .HasColumnName("page_data")
                    .IsUnicode(false);

                entity.Property(e => e.PageSequence).HasColumnName("page_sequence");

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

            modelBuilder.Entity<MCourseStartAndStopTime>(entity =>
            {
                entity.ToTable("m_course_start_and_stop_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserIdFk)
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.CourseEndTime)
                    .HasColumnName("course_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CourseIdFk)
                    .HasColumnName("course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseStartTime)
                    .HasColumnName("course_start_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseStartAndStopTime)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_course_start_and_stop_time_AspNetUsers");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseStartAndStopTime)
                    .HasForeignKey(d => d.CourseIdFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_course_start_and_stop_time_m_course");
            });

            modelBuilder.Entity<MCourseTakers>(entity =>
            {
                entity.ToTable("m_course_takers");

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
                    .IsUnicode(false);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseTopic)
                    .HasForeignKey(d => d.CourseIdFk)
                    .HasConstraintName("FK_m_course_topic_m_course");
            });

            modelBuilder.Entity<MCourseWorkProgress>(entity =>
            {
                entity.ToTable("m_course_work_progress");

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

                entity.Property(e => e.CoursePageIdFk)
                    .IsRequired()
                    .HasColumnName("course_page_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopicIdFk)
                    .HasColumnName("topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MCourseWorkProgress)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .HasConstraintName("FK_m_course_work_progress_AspNetUsers");

                entity.HasOne(d => d.CourseIdFkNavigation)
                    .WithMany(p => p.MCourseWorkProgress)
                    .HasForeignKey(d => d.CourseIdFk)
                    .HasConstraintName("FK_m_course_work_progress_m_course");

                entity.HasOne(d => d.TopicIdFkNavigation)
                    .WithMany(p => p.MCourseWorkProgress)
                    .HasForeignKey(d => d.TopicIdFk)
                    .HasConstraintName("FK_m_course_work_progress_m_course_topic");
            });

            modelBuilder.Entity<MCourseWorkQuestion>(entity =>
            {
                entity.ToTable("m_course_work_question");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EQuestionTypeIdFk)
                    .IsRequired()
                    .HasColumnName("e_question_type_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCourseMaterialIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_material_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionSequence).HasColumnName("question_sequence");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnName("question_text")
                    .IsUnicode(false);

                entity.HasOne(d => d.EQuestionTypeIdFkNavigation)
                    .WithMany(p => p.MCourseWorkQuestion)
                    .HasForeignKey(d => d.EQuestionTypeIdFk)
                    .HasConstraintName("FK_m_course_work_question_e_question_answer_type");

                entity.HasOne(d => d.MCourseMaterialIdFkNavigation)
                    .WithMany(p => p.MCourseWorkQuestion)
                    .HasForeignKey(d => d.MCourseMaterialIdFk)
                    .HasConstraintName("FK_m_course_work_question_m_course_material");
            });

            modelBuilder.Entity<MCourseWorkQuestionAnswerOptions>(entity =>
            {
                entity.ToTable("m_course_work_question_answer_options");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Explanation)
                    .HasColumnName("explanation")
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrectAnswer).HasColumnName("is_correct_answer");

                entity.Property(e => e.MCourseWorkQuestionIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_work_question_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionText)
                    .IsRequired()
                    .HasColumnName("option_text")
                    .IsUnicode(false);

                entity.HasOne(d => d.MCourseWorkQuestionIdFkNavigation)
                    .WithMany(p => p.MCourseWorkQuestionAnswerOptions)
                    .HasForeignKey(d => d.MCourseWorkQuestionIdFk)
                    .HasConstraintName("FK_m_course_work_question_answer_options_m_course_work_question");
            });

            modelBuilder.Entity<MMedia>(entity =>
            {
                entity.HasKey(e => e.IdFileNameGuid);

                entity.ToTable("m_media");

                entity.Property(e => e.IdFileNameGuid)
                    .HasColumnName("id_file_name_guid")
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasColumnName("original_file_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MQuestion>(entity =>
            {
                entity.ToTable("m_question");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EQuestionTypeIdFk)
                    .IsRequired()
                    .HasColumnName("e_question_type_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCourseTopicIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_topic_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionSequence).HasColumnName("question_sequence");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnName("question_text")
                    .IsUnicode(false);

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

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Explanation)
                    .HasColumnName("explanation")
                    .IsUnicode(false);

                entity.Property(e => e.IsCorrectAnswer).HasColumnName("is_correct_answer");

                entity.Property(e => e.MCourseIdFk)
                    .IsRequired()
                    .HasColumnName("m_course_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MQuestionIdFk)
                    .IsRequired()
                    .HasColumnName("m_question_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<MUsersAnswersCourseMaterial>(entity =>
            {
                entity.ToTable("m_users_answers_course_material");

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

                entity.Property(e => e.CourseMaterialIdFk)
                    .IsRequired()
                    .HasColumnName("course_material_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseMaterialQuestionIdFk)
                    .IsRequired()
                    .HasColumnName("course_material_question_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAnswered)
                    .HasColumnName("date_answered")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AspNetUserIdFkNavigation)
                    .WithMany(p => p.MUsersAnswersCourseMaterial)
                    .HasForeignKey(d => d.AspNetUserIdFk)
                    .HasConstraintName("FK_m_users_answers_coure_material_AspNetUsers");

                entity.HasOne(d => d.CourseMaterialIdFkNavigation)
                    .WithMany(p => p.MUsersAnswersCourseMaterial)
                    .HasForeignKey(d => d.CourseMaterialIdFk)
                    .HasConstraintName("FK_m_users_answers_coure_material_m_course_material");

                entity.HasOne(d => d.CourseMaterialQuestionIdFkNavigation)
                    .WithMany(p => p.MUsersAnswersCourseMaterial)
                    .HasForeignKey(d => d.CourseMaterialQuestionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_users_answers_course_material_m_course_work_question");
            });

            modelBuilder.Entity<MUsersAssesmentMarks>(entity =>
            {
                entity.ToTable("m_users_assesment_marks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserIdFk)
                    .IsRequired()
                    .HasColumnName("asp_net_user_id_fk")
                    .HasMaxLength(450);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.MContinouseAssesmentIdFk)
                    .IsRequired()
                    .HasColumnName("m_continouse_assesment_id_fk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage)
                    .HasColumnName("percentage")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.MContinouseAssesmentIdFkNavigation)
                    .WithMany(p => p.MUsersAssesmentMarks)
                    .HasForeignKey(d => d.MContinouseAssesmentIdFk)
                    .HasConstraintName("FK_m_users_assesment_marks_m_continouse_assesment");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
