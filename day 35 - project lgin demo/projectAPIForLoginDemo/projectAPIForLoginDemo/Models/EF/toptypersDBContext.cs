using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace projectAPIForLoginDemo.Models.EF
{
    public partial class toptypersDBContext : DbContext
    {
        public toptypersDBContext()
        {
        }

        public toptypersDBContext(DbContextOptions<toptypersDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoginTable> LoginTables { get; set; } = null!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:p2project.database.windows.net,1433;Initial Catalog=toptypersDB;Persist Security Info=False;User ID=project2;Password=Password@4567;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__loginTab__F267251E13AA80B9");

                entity.ToTable("loginTable");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountPassword)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("accountPassword");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("isAdmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lastName");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__userProf__F267251E56348F20");

                entity.ToTable("userProfile");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("accountId");

                entity.Property(e => e.AvatarLink)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("avatarLink");

                entity.Property(e => e.KeyboardLayout)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("keyboardLayout");

                entity.Property(e => e.UserElo).HasColumnName("UserELO");

                entity.Property(e => e.Wpm).HasColumnName("WPM");

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.UserProfile)
                    .HasForeignKey<UserProfile>(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userProfi__accou__160F4887");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
