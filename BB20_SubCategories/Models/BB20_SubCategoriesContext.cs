using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_SubCategories.Models
{
    public partial class BB20_SubCategoriesContext : DbContext
    {
        public BB20_SubCategoriesContext()
        {
        }

        public BB20_SubCategoriesContext(DbContextOptions<BB20_SubCategoriesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<SubCategoryThumbNail> SubCategoryThumbNails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.HasIndex(e => e.CategoryId, "IX_Category");

                entity.HasIndex(e => e.SubCategoryId, "IX_SubCategory");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SubCategoryID")
                    .HasComment("ID of the sub category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("ID of the category this sub category belongs to");

                entity.Property(e => e.CategoryLandPageDesc).HasComment("Main Category landing page description");

                entity.Property(e => e.CategoryLandPageHead).HasComment("Main Category landing page Headline");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DisplayStatus).HasComment("Status of the sub category (display = 0 or hidden = 1)");

                entity.Property(e => e.FtinBannerIcon)
                    .HasColumnName("FTInBannerIcon")
                    .HasComment("Feature in the banner icons section");

                entity.Property(e => e.FtinHeaderAndFooter)
                    .HasColumnName("FTinHeaderAndFooter")
                    .HasComment("Feature In header and footer");

                entity.Property(e => e.FtinTitle)
                    .HasColumnName("FTInTitle")
                    .HasComment("Feature in the titles section");

                entity.Property(e => e.Icon).HasComment("Sub Category Icon");

                entity.Property(e => e.IsActive).HasComment("If the category is in active status (0 = active and 1 = Inactive)");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .HasComment("Name of the sub category");

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

                entity.Property(e => e.Static).HasComment("If the sub category is static");

                entity.Property(e => e.SubCategoryLandPageDesc).HasComment("Sub category landing page description");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");

                entity.Property(e => e.UseExternalUrl)
                    .HasColumnName("UseExternalURL")
                    .HasComment("Use external url");
            });

            modelBuilder.Entity<SubCategoryThumbNail>(entity =>
            {
                entity.HasKey(e => e.ThumbNailId);

                entity.ToTable("SubCategoryThumbNail");

                entity.HasIndex(e => e.SubCategoryId, "IX_SubCategoryID");

                entity.HasIndex(e => e.ThumbNailId, "IX_SubCategoryThumbNail");

                entity.Property(e => e.ThumbNailId)
                    .HasColumnName("ThumbNailID")
                    .HasComment("Id of the sub category thumb nail");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.Image).HasComment("Image");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SubCategoryID")
                    .HasComment("ID of the sub category it belongs");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.SubCategoryThumbNails)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoryThumbNail_SubCategory");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
