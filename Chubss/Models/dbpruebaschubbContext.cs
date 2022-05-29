using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Chubss.Models
{
    public partial class dbpruebaschubbContext : DbContext
    {
        public dbpruebaschubbContext()
        {
        }

        public dbpruebaschubbContext(DbContextOptions<dbpruebaschubbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalogo> Catalogos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaProducto> PersonaProductos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BRAONPC\\SQLEXPRESS;Database=dbpruebaschubb;User ID=sa;Password=123**abc;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo)
                    .HasName("PK__Catalogo__74D5F87F1455F9D2");

                entity.ToTable("Catalogo");

                entity.Property(e => e.IdCatalogo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_Catalogo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdTabla)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_tabla");

                entity.Property(e => e.TipoTabla)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_tabla");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__214BF527351B3D7D");

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_Persona");

                entity.Property(e => e.Edad)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_cliente");

                entity.Property(e => e.Telefono).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<PersonaProducto>(entity =>
            {
                entity.HasKey(e => e.IdPersonaProducto)
                    .HasName("PK__Persona___C82CFB2564B83106");

                entity.ToTable("Persona_Producto");

                entity.Property(e => e.IdPersonaProducto)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_Persona_Producto");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCatalagoProducto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_Catalago_Producto");

                entity.Property(e => e.IdPersona)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_Persona");

                entity.Property(e => e.Prima).HasColumnType("numeric(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
