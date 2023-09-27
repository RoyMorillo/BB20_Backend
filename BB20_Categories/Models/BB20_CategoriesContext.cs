using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_Categories.Models
{
    public partial class BB20_CategoriesContext : DbContext
    {
        public BB20_CategoriesContext()
        {
        }

        public BB20_CategoriesContext(DbContextOptions<BB20_CategoriesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.CategoryId, "IX_Category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("ID of the category");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DisplayStatus).HasComment("Status of the category (display = 0 or hidden = 1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the category");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
