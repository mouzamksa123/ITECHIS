using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Shared.Entities.Entities;

public partial class ItechisCoreContext : DbContext
{
    public ItechisCoreContext()
    {
    }

    public ItechisCoreContext(DbContextOptions<ItechisCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HisAppointment> HisAppointments { get; set; }

    public virtual DbSet<HisClinic> HisClinics { get; set; }

    public virtual DbSet<HisDoctor> HisDoctors { get; set; }

    public virtual DbSet<HisDoctorCalender> HisDoctorCalenders { get; set; }

    public virtual DbSet<HisDoctorClinicMapping> HisDoctorClinicMappings { get; set; }

    public virtual DbSet<HisDoctorSchedule> HisDoctorSchedules { get; set; }

    public virtual DbSet<HisDoctorSpecialityMapping> HisDoctorSpecialityMappings { get; set; }

    public virtual DbSet<HisParameter> HisParameters { get; set; }

    public virtual DbSet<HisParameterType> HisParameterTypes { get; set; }

    public virtual DbSet<HisPatientId> HisPatientIds { get; set; }

    public virtual DbSet<HisRole> HisRoles { get; set; }

    public virtual DbSet<HisUser> HisUsers { get; set; }

    public virtual DbSet<HisUserRole> HisUserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=akifpc;Initial Catalog=ITECHIS;Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HisAppointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentNo);

            entity.ToTable("HIS_Appointment");

            entity.Property(e => e.AppointmentDate).HasColumnType("date");
            entity.Property(e => e.ArrivedOn).HasColumnType("datetime");
            entity.Property(e => e.BookedOn).HasColumnType("datetime");
            entity.Property(e => e.ConfirmedIon)
                .HasColumnType("datetime")
                .HasColumnName("ConfirmedIOn");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.E)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RescheduledOn).HasColumnType("datetime");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisClinic>(entity =>
        {
            entity.HasKey(e => e.ClinicId);

            entity.ToTable("HIS_Clinic");

            entity.Property(e => e.ClinicName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HisDoctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId);

            entity.ToTable("HIS_Doctor");

            entity.Property(e => e.Address)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisDoctorCalender>(entity =>
        {
            entity.HasKey(e => e.DoctorCalenderId);

            entity.ToTable("HIS_DoctorCalender");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GregDate).HasColumnType("date");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisDoctorClinicMapping>(entity =>
        {
            entity.HasKey(e => e.DoctorClinicId);

            entity.ToTable("HIS_DoctorClinicMapping");

            entity.Property(e => e.DoctorClinicId).HasColumnName("DoctorClinicID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HisDoctorSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId);

            entity.ToTable("HIS_DoctorSchedule");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SlotDuration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisDoctorSpecialityMapping>(entity =>
        {
            entity.HasKey(e => e.DoctorSpecialityId);

            entity.ToTable("HIS_DoctorSpecialityMapping");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HisParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId);

            entity.ToTable("HIS_Parameter");

            entity.Property(e => e.ParameterId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ParameterName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ParameterNameN).HasMaxLength(200);

            entity.HasOne(d => d.ParameterType).WithMany(p => p.HisParameters)
                .HasForeignKey(d => d.ParameterTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HIS_Parameter_HIS_ParameterType");
        });

        modelBuilder.Entity<HisParameterType>(entity =>
        {
            entity.HasKey(e => e.ParameterTypeId);

            entity.ToTable("HIS_ParameterType");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.ParameterTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ParameterTypeNameN).HasMaxLength(200);
        });

        modelBuilder.Entity<HisPatientId>(entity =>
        {
            entity.HasKey(e => e.PatientId);

            entity.ToTable("HIS_PatientId");

            entity.Property(e => e.Address)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("HIS_Role");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("HIS_User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HisUserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HIS_UserRole");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EditedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
