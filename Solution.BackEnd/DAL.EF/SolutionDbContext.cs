using DAL.DO.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public partial class SolutionDbContext : DbContext
    {
        public SolutionDbContext(DbContextOptions<SolutionDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Autos> Autos { get; set; }
        public virtual DbSet<Combustible> Combustible { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<TiposAutos> TiposAutos { get; set; }
        public virtual DbSet<Transmisiones> Transmisiones { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Autos>(entity =>
            {
                entity.HasIndex(e => e.CombustibleId);

                entity.HasIndex(e => e.EstadoId);

                entity.HasIndex(e => e.MarcaId);

                entity.HasIndex(e => e.ModeloId);

                entity.HasIndex(e => e.TipoId);

                entity.HasIndex(e => e.TransmisionId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Combustible)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.CombustibleId);

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.EstadoId);

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.MarcaId);

                entity.HasOne(d => d.Modelo)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.ModeloId);

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.TipoId);

                entity.HasOne(d => d.Transmision)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.TransmisionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Combustible>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modelos>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.MarcaId)
                    .HasConstraintName("R_5");
            });


            modelBuilder.Entity<TiposAutos>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("TiposAutos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transmisiones>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

         


            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
