using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Shared.Entities.Entities;

public partial class MatrimonyCoreContext : DbContext
{
    public MatrimonyCoreContext()
    {
    }

    public MatrimonyCoreContext(DbContextOptions<MatrimonyCoreContext> options)
        : base(options)
    {
    }

     

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MOUZAM\\MSSQLSERVER02;Database=ItecDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => e.UserLoginId).HasName("PK_UserLogin");

            entity.ToTable("UserLogin");

            entity.Property(e => e.UserLoginId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoginPassword)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime"); 
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserLoginName)
                .HasMaxLength(50)
                .IsUnicode(false);
        }); 

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
