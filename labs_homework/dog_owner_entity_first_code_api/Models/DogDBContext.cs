using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dog_owner_entity_first_code_api.Models
{
    public partial class DogDBContext : DbContext
    {
        public DogDBContext()
        {
        }

        public DogDBContext(DbContextOptions<DogDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dogs> Dogs { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DogDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dogs>(entity =>
            {
                entity.Property(e => e.DogBreed).HasMaxLength(50);

                entity.Property(e => e.DogName).HasMaxLength(50);

                entity.Property(e => e.DogSize).HasMaxLength(50);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Dogs)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__Dogs__OwnerId__286302EC");
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.HasKey(e => e.OwnerId)
                    .HasName("PK__Owners__819385B8BECF0A01");

                entity.Property(e => e.OwnerName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
