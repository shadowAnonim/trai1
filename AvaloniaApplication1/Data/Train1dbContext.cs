using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication1.Data;

public partial class Train1dbContext : DbContext
{
    public Train1dbContext()
    {
    }

    public Train1dbContext(DbContextOptions<Train1dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User Id=postgres;Password=12345;Database=train1db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_pk");

            entity.ToTable("client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middle_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Photo)
                .HasMaxLength(20)
                .HasColumnName("photo");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pk");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
