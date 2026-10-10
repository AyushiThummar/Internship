using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MultiModelDemo.Models;

public partial class StudentInfoDbContext : DbContext
{
    public StudentInfoDbContext()
    {
    }

    public StudentInfoDbContext(DbContextOptions<StudentInfoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("pk_courseId");

            entity.ToTable("Course");

            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.CourseDuration)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("courseDuration");
            entity.Property(e => e.CourseFee).HasColumnName("courseFee");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("courseName");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => e.RecNo).HasName("pk_recNo");

            entity.ToTable("Fee");

            entity.Property(e => e.RecNo).HasColumnName("recNo");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Fdate).HasColumnName("fdate");
            entity.Property(e => e.StuId).HasColumnName("stuId");

            entity.HasOne(d => d.Stu).WithMany(p => p.Fees)
                .HasForeignKey(d => d.StuId)
                .HasConstraintName("fk_stuId");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StuId).HasName("pk_stuId");

            entity.ToTable("Student");

            entity.Property(e => e.StuId).HasColumnName("stuId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.StuDob).HasColumnName("stuDob");
            entity.Property(e => e.StuGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stuGender");
            entity.Property(e => e.StuName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("stuName");
            entity.Property(e => e.StuPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stuPhone");

            entity.HasOne(d => d.Course).WithMany(p => p.Students)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("fk_courseId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
