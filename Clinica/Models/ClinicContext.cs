using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Clinica.Models;

namespace Clinica.Models
{
    public partial class ClinicContext : DbContext
    {
        public ClinicContext()
        {
        }

        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<SpecialtyRoom> Specialties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=localhost; database=Clinic; integrated security=true; Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("Patient");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("idUser");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<SpecialtyRoom>(entity =>
            {
                entity.HasKey(e => e.idSpecialtyRoom);

                entity.ToTable("SpecialtyRoom");

                entity.Property(e => e.number).HasColumnName("number"); ;

                entity.Property(e => e.number).ValueGeneratedNever();

                entity.Property(e => e.specialty)
                    .HasMaxLength(50)
                    .HasColumnName("specialty");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdDoctor)
                    .HasMaxLength(50)
                    .HasColumnName("idDoctor");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.Property(e => e.Speciality).HasColumnName("speciality");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.idEquipment);

                entity.ToTable("Equipment");

                entity.Property(e => e.name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.datePurchase)
                    .HasColumnType("datetime")
                    .HasColumnName("datePurchase");

                entity.Property(e => e.assetNumber).HasColumnName("assetNumber");

                entity.Property(e => e.serial).HasColumnName("serial");

                entity.Property(e => e.description).HasColumnName("description");
                entity.Property(e => e.specialty).HasColumnName("specialty");
                entity.Property(e => e.consultingRoom).HasColumnName("consultingRoom");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Clinica.Models.Appointments> Appointments { get; set; }

        public DbSet<Clinica.Models.Equipment> Equipment { get; set; }

        public DbSet<Clinica.Models.Specialty> Specialty { get; set; }
    }
}
