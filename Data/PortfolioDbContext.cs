using System;
using System.Collections.Generic;
using AkademiqPortfolio.Data;
using Microsoft.EntityFrameworkCore;


namespace Portfolio.Data;

public partial class PortfolioDbContext : DbContext
{
    public PortfolioDbContext()
    {
    }

    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<CategoriesTable> Categories { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Expertise> Expertises { get; set; }

    public virtual DbSet<HomePage> HomePages { get; set; }

    public virtual DbSet<ProjectsTable> Projects { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<SkillTable> SkillTables { get; set; }

    public virtual DbSet<SocialMedium> SocialMedia { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    public virtual DbSet<İntroduction> İntroductions { get; set; }

    public DbSet<Message> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=OMER\\SQLEXPRESS;Database=PortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<About>(entity =>
        {
            entity.ToTable("About");

            entity.Property(e => e.Cvlink).HasColumnName("CVLink");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<CategoriesTable>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("CategoriesTable");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.MailAddress).HasMaxLength(150);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.InstutionName).HasMaxLength(500);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(300);
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<Expertise>(entity =>
        {
            entity.ToTable("Expertise");
        });

        modelBuilder.Entity<HomePage>(entity =>
        {
            entity.HasKey(e => e.HomeId);

            entity.ToTable("HomePage");

            entity.Property(e => e.HomeId).HasColumnName("HomeID");
            entity.Property(e => e.Imagepath)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NameSurname).HasMaxLength(50);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProjectsTable>(entity =>
        {
            entity.ToTable("ProjectsTable");
            entity.HasKey(e => e.ProjectId);

            entity.HasOne(d => d.Category)
                  .WithMany(p => p.ProjectsTables) // CategoriesTable içindeki liste adı
                  .HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServicesId);

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Icon).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<SkillTable>(entity =>
        {
            entity.HasKey(e => e.SkillId);

            entity.ToTable("SkillTable");

            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<SocialMedium>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<İntroduction>(entity =>
        {
            entity.ToTable("İntroduction");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
