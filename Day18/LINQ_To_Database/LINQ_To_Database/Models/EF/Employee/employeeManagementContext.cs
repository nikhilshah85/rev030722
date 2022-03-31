using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LINQ_To_Database.Models.EF.Employee
{
    public partial class employeeManagementContext : DbContext
    {
        public employeeManagementContext()
        {
        }

        public employeeManagementContext(DbContextOptions<employeeManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-H5HFUEB\\TRAINERINSTANCE; database=employeeManagement;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactInfo");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("empAddress");

                entity.Property(e => e.EmpCellNo).HasColumnName("empCellNo");

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empEmail");

                entity.Property(e => e.EmpEmergencyContact).HasColumnName("empEmergencyContact");

                entity.Property(e => e.EmpLinkedInProfile)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("empLinkedInProfile");

                entity.Property(e => e.EmpNo).HasColumnName("empNo");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("fk_empNo");
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__employee__AFB33592CAA14C7C");

                entity.ToTable("employeeInfo");

                entity.Property(e => e.EmpNo)
                    .ValueGeneratedNever()
                    .HasColumnName("empNo");

                entity.Property(e => e.EmpDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empDesignation");

                entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
