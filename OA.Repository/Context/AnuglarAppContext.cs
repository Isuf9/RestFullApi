using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OA.DomainEntities.Models;

#nullable disable

namespace OA.Repository.Models
{
    public partial class AnuglarAppContext : DbContext
    {
        public AnuglarAppContext()
        {
        }

        public AnuglarAppContext(DbContextOptions<AnuglarAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PaymentDetailsForClient> PaymentDetailsForClients { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=AngularApp; user id=sa; password=isufisuf");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetailsForClient>(entity =>
            {
                entity.HasKey(e => e.Pmid)
                    .HasName("PK__PaymentD__5C86FF463E0B56AD");

                entity.ToTable("PaymentDetailsForClient");

                entity.Property(e => e.Pmid)
                    .ValueGeneratedNever()
                    .HasColumnName("PMId");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardOwnerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.ExpariationDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
