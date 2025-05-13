using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class Foy5Context : DbContext
{
    public Foy5Context()
    {
    }

    public Foy5Context(DbContextOptions<Foy5Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TBolum> TBolums { get; set; }

    public virtual DbSet<TDer> TDers { get; set; }

    public virtual DbSet<TFakulte> TFakultes { get; set; }

    public virtual DbSet<TOgrenci> TOgrencis { get; set; }

    public virtual DbSet<TOgrenciDer> TOgrenciDers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Foy5;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBolum>(entity =>
        {
            entity.HasKey(e => e.BolumId).HasName("PK__tBolum__5346F0CB13B921B8");

            entity.ToTable("tBolum");

            entity.Property(e => e.BolumId)
                .ValueGeneratedNever()
                .HasColumnName("bolumID");
            entity.Property(e => e.BolumAd)
                .HasMaxLength(100)
                .HasColumnName("bolumAd");
            entity.Property(e => e.FakulteId).HasColumnName("fakulteID");

            entity.HasOne(d => d.Fakulte).WithMany(p => p.TBolums)
                .HasForeignKey(d => d.FakulteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tBolum__fakulteI__2A4B4B5E");
        });

        modelBuilder.Entity<TDer>(entity =>
        {
            entity.HasKey(e => e.DersId).HasName("PK__tDers__B069CEB4901B3DD6");

            entity.ToTable("tDers");

            entity.Property(e => e.DersId)
                .ValueGeneratedNever()
                .HasColumnName("dersID");
            entity.Property(e => e.DersAd)
                .HasMaxLength(100)
                .HasColumnName("dersAd");
        });

        modelBuilder.Entity<TFakulte>(entity =>
        {
            entity.HasKey(e => e.FakulteId).HasName("PK__tFakulte__40AAE88C7B4C208C");

            entity.ToTable("tFakulte");

            entity.Property(e => e.FakulteId)
                .ValueGeneratedNever()
                .HasColumnName("fakulteID");
            entity.Property(e => e.FakulteAd)
                .HasMaxLength(100)
                .HasColumnName("fakulteAd");
        });

        modelBuilder.Entity<TOgrenci>(entity =>
        {
            entity.HasKey(e => e.OgrenciId).HasName("PK__tOgrenci__91C9526C692EB8DC");

            entity.ToTable("tOgrenci");

            entity.Property(e => e.OgrenciId)
                .ValueGeneratedNever()
                .HasColumnName("ogrenciID");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.BolumId).HasColumnName("bolumID");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .HasColumnName("soyad");

            entity.HasOne(d => d.Bolum).WithMany(p => p.TOgrencis)
                .HasForeignKey(d => d.BolumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tOgrenci__bolumI__2D27B809");
        });

        modelBuilder.Entity<TOgrenciDer>(entity =>
        {
            entity.HasKey(e => new { e.OgrenciId, e.DersId, e.Yil, e.Yariyil }).HasName("PK__tOgrenci__3370805CAF5B83A3");

            entity.ToTable("tOgrenciDers");

            entity.Property(e => e.OgrenciId).HasColumnName("ogrenciID");
            entity.Property(e => e.DersId).HasColumnName("dersID");
            entity.Property(e => e.Yil).HasColumnName("yil");
            entity.Property(e => e.Yariyil).HasColumnName("yariyil");
            entity.Property(e => e.Final).HasColumnName("final");
            entity.Property(e => e.Vize).HasColumnName("vize");

            entity.HasOne(d => d.Ders).WithMany(p => p.TOgrenciDers)
                .HasForeignKey(d => d.DersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tOgrenciD__dersI__32E0915F");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.TOgrenciDers)
                .HasForeignKey(d => d.OgrenciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tOgrenciD__ogren__31EC6D26");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
