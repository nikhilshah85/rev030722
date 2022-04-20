using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace projectRestAPI.Models.EF
{
    public partial class projectdemoDBContext : DbContext
    {
        public projectdemoDBContext()
        {
        }

        public projectdemoDBContext(DbContextOptions<projectdemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:prjectserver.database.windows.net;database=projectdemoDB;User id=trainer;Password=Password@1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("pk_deptNo");

                entity.ToTable("Department");

                entity.Property(e => e.DeptNo)
                    .ValueGeneratedNever()
                    .HasColumnName("deptNo");

                entity.Property(e => e.DeptLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptLocation");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptName");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("pk_empNo");

                entity.ToTable("employee");

                entity.HasIndex(e => e.EmpSsn, "unk_empssn")
                    .IsUnique();

                entity.Property(e => e.EmpNo)
                    .ValueGeneratedNever()
                    .HasColumnName("empNo");

                entity.Property(e => e.EmpAge).HasColumnName("empAge");

                entity.Property(e => e.EmpDept).HasColumnName("empDept");

                entity.Property(e => e.EmpDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empDesignation");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpSalary).HasColumnName("empSalary");

                entity.Property(e => e.EmpSsn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("empSSN");

                entity.HasOne(d => d.EmpDeptNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpDept)
                    .HasConstraintName("fk_empDepartment");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
