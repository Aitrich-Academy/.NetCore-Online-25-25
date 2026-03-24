using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class DbHireMeNowWebApiContext : DbContext
{
    public DbHireMeNowWebApiContext()
    {
    }

    public DbHireMeNowWebApiContext(DbContextOptions<DbHireMeNowWebApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }
    public virtual DbSet<SignUpRequest> SignUpRequests { get; set; }

    public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobPost> JobPosts { get; set; }

    public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

    public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

    public virtual DbSet<JobSeeker> JobSeekers { get; set; }

    public virtual DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }

    public virtual DbSet<Location> Locations { get; set; }


    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Resume> Resumes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }
	public virtual DbSet<SavedJob> SavedJobs { get; set; }
	public virtual DbSet<Interview> Interviews { get; set; }
	public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<MessageGroup> MessageGroups { get; set; }
    public virtual DbSet<GroupMember> GroupMember { get; set; }
    // 


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // -------------------------
        // CompanyUser
        // -------------------------
        modelBuilder.Entity<CompanyUser>(entity =>
        {
            entity.ToTable("CompanyUser");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CompanyNavigation)
                  .WithMany() // no collection on JobProviderCompany
                  .HasForeignKey(d => d.Company)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_CompanyUser_JobProviderCompany");
        });

        // -------------------------
        // Industry
        // -------------------------
        modelBuilder.Entity<Industry>(entity =>
        {
            entity.ToTable("Industry");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(50).IsUnicode(false);
        });

        // -------------------------
        // JobCategory
        // -------------------------
        modelBuilder.Entity<JobCategory>(entity =>
        {
            entity.ToTable("JobCategory");

            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(50).IsUnicode(false);
        });

        // -------------------------
        // Location
        // -------------------------
        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Discription).HasMaxLength(50).IsUnicode(false);
        });

        // -------------------------
        // JobProviderCompany
        // -------------------------
        modelBuilder.Entity<JobProviderCompany>(entity =>
        {
            entity.ToTable("JobProviderCompany");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LegalName).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Summary).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Address).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Website).HasMaxLength(50).IsUnicode(false);

            entity.HasOne(d => d.LocationNavigation)
                  .WithMany()
                  .HasForeignKey(d => d.LocationId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobProviderCompany_Location");

            entity.HasOne(d => d.Industry)
                  .WithMany()
                  .HasForeignKey(d => d.IndustryId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobProviderCompany_Industry");
        });

        // -------------------------
        // JobPost
        // -------------------------
        modelBuilder.Entity<JobPost>(entity =>
        {
            entity.ToTable("JobPost");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.JobTitle).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.JobSummary).HasMaxLength(250).IsUnicode(false);
            entity.Property(e => e.PostedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Location)
                  .WithMany()
                  .HasForeignKey(d => d.LocationId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobPost_Location");

            entity.HasOne(d => d.Industry)
                  .WithMany()
                  .HasForeignKey(d => d.IndustryId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobPost_Industry");

            entity.HasOne(d => d.Company)
                  .WithMany()
                  .HasForeignKey(d => d.CompanyId)
                  .OnDelete(DeleteBehavior.Restrict) // ← must be Restrict
                  .HasConstraintName("FK_JobPost_JobProviderCompany_CompanyId");

            entity.HasOne(d => d.PostedByNavigation)
                  .WithMany()
                  .HasForeignKey(d => d.PostedBy)
                  .OnDelete(DeleteBehavior.Restrict) // ← must be Restrict
                  .HasConstraintName("FK_JobPost_PostedByCompanyUser");

            entity.HasOne(d => d.JobCategory)
                  .WithMany()
                  .HasForeignKey(d => d.CategoryId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobPost_JobCategory");
        });

        // -------------------------
        // JobResponsibility
        // -------------------------
        modelBuilder.Entity<JobResponsibility>(entity =>
        {
            entity.ToTable("JobResponsibility");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250).IsUnicode(false);

            entity.HasOne(d => d.JobPostNavigation)
                  .WithMany(p => p.JobResponsibilities)
                  .HasForeignKey(d => d.JobPost)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_JobResponsibility_JobPost");
        });

        // -------------------------
        // JobSeekerProfile
        // -------------------------
        modelBuilder.Entity<JobSeekerProfile>(entity =>
        {
            entity.ToTable("JobSeekerProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Resume)
                  .WithMany()
                  .HasForeignKey(d => d.ResumeId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        });

        // -------------------------
        // WorkExperience
        // -------------------------
        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Experiences");

            entity.ToTable("WorkExperience");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.JobSeekerProfile)
                  .WithMany()
                  .HasForeignKey(d => d.JobSeekerProfileId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_WorkExperience_JobSeekerProfile");
        });

        // -------------------------
        // JobSeekerProfileSkill (many-to-many)
        // -------------------------
        modelBuilder.Entity<JobSeekerProfileSkill>()
            .HasKey(jps => new { jps.JobSeekerProfileId, jps.SkillId });

        modelBuilder.Entity<JobSeekerProfileSkill>()
            .HasOne(jps => jps.JobSeekerProfile)
            .WithMany(jp => jp.JobSeekerProfileSkills)
            .HasForeignKey(jps => jps.JobSeekerProfileId);

        // -------------------------
        // Resume
        // -------------------------
        modelBuilder.Entity<Resume>(entity =>
        {
            entity.ToTable("Resume");
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        // -------------------------
        // Qualification
        // -------------------------
        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.ToTable("Qualification");
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250).IsUnicode(false);

            entity.HasOne(d => d.JobPost)
                  .WithMany()
                  .HasForeignKey(d => d.JobPostId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Qualification_JobPost");
        });

        // -------------------------
        // Skill
        // -------------------------
        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");
            entity.Property(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250).IsUnicode(false);
        });

        // -------------------------
        // Role (no key)
        // -------------------------
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasNoKey().ToTable("Role");
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
