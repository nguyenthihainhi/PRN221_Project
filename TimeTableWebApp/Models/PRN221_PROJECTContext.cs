using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimeTableWebApp.Models
{
    public partial class PRN221_PROJECTContext : DbContext
    {
        public PRN221_PROJECTContext()
        {
        }

        public PRN221_PROJECTContext(DbContextOptions<PRN221_PROJECTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attandance> Attandances { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<Lecturer> Lecturers { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentGroup> StudentGroups { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<TimeSlot> TimeSlots { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-GM3477H;uid=nhinth;pwd=123456789;database=PRN221_PROJECT;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attandance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attandance");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Present).HasColumnName("present");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasColumnName("record_time");

                entity.Property(e => e.Sesid).HasColumnName("sesid");

                entity.Property(e => e.Stid).HasColumnName("stid");

                entity.HasOne(d => d.Session)
                    .WithMany()
                    .HasForeignKey(d => d.Sesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attandance_Session");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.Stid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attandance_Student");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_Class_1");

                entity.ToTable("Class");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .HasColumnName("cname");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Gid);

                entity.ToTable("Group");

                entity.Property(e => e.Gid)
                    .ValueGeneratedNever()
                    .HasColumnName("gid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Subid).HasColumnName("subid");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Class");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.Subid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Subject");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.HasKey(e => e.Lid);

                entity.ToTable("Lecturer");

                entity.Property(e => e.Lid)
                    .ValueGeneratedNever()
                    .HasColumnName("lid");

                entity.Property(e => e.Displayname)
                    .HasMaxLength(150)
                    .HasColumnName("displayname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lname");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Room");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("rid");

                entity.Property(e => e.Rname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rname");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.Sesid);

                entity.ToTable("Session");

                entity.Property(e => e.Sesid)
                    .ValueGeneratedNever()
                    .HasColumnName("sesid");

                entity.Property(e => e.Attanded).HasColumnName("attanded");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Lid).HasColumnName("lid");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.Gid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_Group");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.Lid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_Lecturer");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.Rid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_Room");

                entity.HasOne(d => d.TimeSlot)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_TimeSlot");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Stid);

                entity.ToTable("Student");

                entity.Property(e => e.Stid)
                    .ValueGeneratedNever()
                    .HasColumnName("stid");

                entity.Property(e => e.Displayname)
                    .HasMaxLength(150)
                    .HasColumnName("displayname");

                entity.Property(e => e.Stname)
                    .HasMaxLength(150)
                    .HasColumnName("stname");
            });

            modelBuilder.Entity<StudentGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student_Group");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Stid).HasColumnName("stid");

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.Gid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Group_Group");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.Stid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Class_Student");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.Subid);

                entity.ToTable("Subject");

                entity.Property(e => e.Subid)
                    .ValueGeneratedNever()
                    .HasColumnName("subid");

                entity.Property(e => e.Subname)
                    .HasMaxLength(50)
                    .HasColumnName("subname");
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("TimeSlot");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
