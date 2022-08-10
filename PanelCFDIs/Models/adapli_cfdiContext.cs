using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PanelCFDIs.Models
{
    public partial class adapli_cfdiContext : DbContext
    {
        public adapli_cfdiContext()
        {
        }

        public adapli_cfdiContext(DbContextOptions<adapli_cfdiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatClaveProdServ> CatClaveProdServ { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Sellos> Sellos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WIN-E5246VB0MCT; Database=adapli_cfdi; User Id=sa; Password=Tangamanga1#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatClaveProdServ>(entity =>
            {
                entity.HasKey(e => e.ClaveProdServ);

                entity.ToTable("catClaveProdServ");

                entity.Property(e => e.ClaveProdServ)
                    .HasColumnName("claveProdServ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("aaaaaEmpresas_PK")
                    .IsClustered(false);

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.Bd)
                    .HasColumnName("bd")
                    .HasMaxLength(50);

                entity.Property(e => e.Calle).HasMaxLength(150);

                entity.Property(e => e.CantFolios).HasColumnName("cantFolios");

                entity.Property(e => e.Cfdi).HasColumnName("cfdi");

                entity.Property(e => e.Clave).HasMaxLength(60);

                entity.Property(e => e.Colonia).HasMaxLength(50);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Daterecord)
                    .HasColumnName("daterecord")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.IdPadre).HasColumnName("idPadre");

                entity.Property(e => e.Localidad).HasMaxLength(80);

                entity.Property(e => e.Mailfrom)
                    .HasColumnName("mailfrom")
                    .HasMaxLength(50);

                entity.Property(e => e.ModoDebug).HasDefaultValueSql("((0))");

                entity.Property(e => e.Municipio).HasMaxLength(80);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NumExt).HasMaxLength(10);

                entity.Property(e => e.NumInt).HasMaxLength(10);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('MEXICO')");

                entity.Property(e => e.Referencia).HasMaxLength(255);

                entity.Property(e => e.Regimen)
                    .HasColumnName("regimen")
                    .HasMaxLength(150);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13);

                entity.Property(e => e.RutaLogo).HasMaxLength(255);

                entity.Property(e => e.RutaTrabajo).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Sellos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnoAprobacion).HasColumnName("anoAprobacion");

                entity.Property(e => e.Certificado).HasMaxLength(255);

                entity.Property(e => e.CertificadoBase64).HasColumnType("ntext");

                entity.Property(e => e.Clave).HasMaxLength(255);

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.LlavePrivada).HasMaxLength(255);

                entity.Property(e => e.LlaveUso)
                    .HasColumnName("llaveUSO")
                    .HasMaxLength(255);

                entity.Property(e => e.NoAprobacion).HasColumnName("noAprobacion");

                entity.Property(e => e.Serie).HasMaxLength(30);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
