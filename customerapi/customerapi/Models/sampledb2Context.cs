using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace customerapi.Models
{
    public partial class sampledb2Context : DbContext
    {
        public sampledb2Context()
        {
        }

        public sampledb2Context(DbContextOptions<sampledb2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Etable> Etables { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-NC99V63M;Initial Catalog=sampledb2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("courses");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("customer id");

                entity.Property(e => e.CustomerAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customer amount");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customer name");
            });

            modelBuilder.Entity<Etable>(entity =>
            {
                entity.ToTable("Etable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("supplier id");

                entity.Property(e => e.SupplierAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplier amount");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("supplier name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
