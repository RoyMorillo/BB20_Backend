using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_InteriorCategories.Models
{
    public partial class BB20_InteriorCategoriesContext : DbContext
    {
        public BB20_InteriorCategoriesContext()
        {
        }

        public BB20_InteriorCategoriesContext(DbContextOptions<BB20_InteriorCategoriesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InteriorCategory> InteriorCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InteriorCategory>(entity =>
            {
                entity.ToTable("InteriorCategory");

                entity.Property(e => e.InteriorCategoryId).HasColumnName("InteriorCategoryID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("ID of the category it belongs");

                entity.Property(e => e.CategoryLandPageDesc).HasComment("Main Category landing page description");

                entity.Property(e => e.CategoryLandPageHead).HasComment("Main Category landing page Headline");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DisplayStatus).HasComment("Status of the interior category (display = 0 or hidden = 1)");

                entity.Property(e => e.Icon).HasComment("Interior Category Icon");

                entity.Property(e => e.IsActive).HasComment("If the category is in active status (0 = active and 1 = Inactive)");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .HasComment("Name of the interior category");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.SeodescMetadata)
                    .HasMaxLength(1500)
                    .HasColumnName("SEODescMetadata")
                    .HasComment("Landing page SEO Description Metadata");

                entity.Property(e => e.SeoprettyUrl)
                    .HasMaxLength(500)
                    .HasColumnName("SEOPrettyURL")
                    .HasComment("Landing page SEO Pretty URL");

                entity.Property(e => e.Seotitle)
                    .HasMaxLength(50)
                    .HasColumnName("SEOTitle")
                    .HasComment("Landing page SEO Title");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SubCategoryID")
                    .HasComment("ID of the sub category this interior category belongs to");

                entity.Property(e => e.SubCategoryLandPageDesc).HasComment("Sub category landing page description");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
