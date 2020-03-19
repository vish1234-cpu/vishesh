using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WEBAPPLICATION_DBFIRST.Models
{
    public partial class DBFIRSTNEWContext : DbContext
    {
        public DBFIRSTNEWContext()
        {
        }

        public DBFIRSTNEWContext(DbContextOptions<DBFIRSTNEWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DBFIRSTNEW;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(x => x.CusId)
                    .HasName("PK__Customer__0AD165377EF04CBA");

                entity.Property(e => e.CusId).HasColumnName("Cus_Id");

                entity.Property(e => e.CusFirstName)
                    .HasColumnName("Cus_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CusLastName)
                    .HasColumnName("Cus_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(x => x.OrderId)
                    .HasName("PK__Orders__F1FF84538B7AE38E");

                entity.Property(e => e.OrderId).HasColumnName("Order_id");

                entity.Property(e => e.CusId).HasColumnName("Cus_Id");

                entity.Property(e => e.OrderAddress)
                    .HasColumnName("Order_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(x => x.CusId)
                    .HasConstraintName("FK__Orders__Cus_Id__286302EC");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(x => x.ProductId)
                    .HasConstraintName("FK__Orders__Product___29572725");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(x => x.ProductId)
                    .HasName("PK__Products__9834FBBA29459584");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductCost)
                    .HasColumnName("Product_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductQuantity).HasColumnName("Product_Quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
