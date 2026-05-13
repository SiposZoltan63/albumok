using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Egyuttesek.Models
{
    public partial class librarydbContext : DbContext
    {
        public librarydbContext()
        {
        }

        public librarydbContext(DbContextOptions<librarydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Albumok> Albumok { get; set; }
        public virtual DbSet<Zeneszek> Zeneszek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=albumok;user=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albumok>(entity =>
            {
                entity.HasKey(e => e.sorszam)
                    .HasName("PRIMARY");

                entity.ToTable("albumok");

                entity.Property(e => e.sorszam)
                    .HasColumnName("sorszam")
                    .HasColumnType("int(11)");

                entity.Property(e => e.egyuttes)
                    .HasColumnName("egyuttes")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.album)
                    .HasColumnName("album")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.kiadas_eve)
                    .HasColumnName("kiadas_eve")
                    .HasColumnType("int(11)");

                entity.Property(e => e.hossz)
                    .HasColumnName("hossz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ar)
                    .HasColumnName("ar")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Zeneszek>(entity =>
            {
                entity.HasKey(e => e.sorszam)
                    .HasName("PRIMARY");

                entity.ToTable("zeneszek");

                entity.Property(e => e.egyuttes)
                     .HasColumnName("egyuttes")
                     .HasMaxLength(100)
                     .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.zenesz)
                    .HasColumnName("egyuttes")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.hangszer)
                    .HasColumnName("hangszer")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
