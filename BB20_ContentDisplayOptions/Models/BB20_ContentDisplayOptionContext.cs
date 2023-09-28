using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_ContentDisplayOptions.Models
{
    public partial class BB20_ContentDisplayOptionContext : DbContext
    {
        public BB20_ContentDisplayOptionContext()
        {
        }

        public BB20_ContentDisplayOptionContext(DbContextOptions<BB20_ContentDisplayOptionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContentDisplayOption> ContentDisplayOptions { get; set; }
        public virtual DbSet<DisplayOptionCategory> DisplayOptionCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentDisplayOption>(entity =>
            {
                entity.ToTable("ContentDisplayOption");

                entity.HasIndex(e => e.ContentDisplayOptionId, "IX_ContentDisplayOption");

                entity.HasIndex(e => e.ContentId, "IX_ContentID");

                entity.Property(e => e.ContentDisplayOptionId)
                    .HasColumnName("ContentDisplayOptionID")
                    .HasComment("ID of the table");

                entity.Property(e => e.ContentId)
                    .HasColumnName("ContentID")
                    .HasComment("ID of the table content");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DodisplayItem)
                    .HasColumnName("DODisplayItem")
                    .HasComment("Display Item");

                entity.Property(e => e.DodisplayItemWdtRng)
                    .HasColumnName("DODisplayItemWDtRng")
                    .HasComment("Display Item Within Date Range");

                entity.Property(e => e.DohideItem)
                    .HasColumnName("DOHideItem")
                    .HasComment("Hide Item");

                entity.Property(e => e.DohomeFeatureItem)
                    .HasColumnName("DOHomeFeatureItem")
                    .HasComment("Feature Item (Home Page)");

                entity.Property(e => e.DohomeFeatureItemWdtRng)
                    .HasColumnName("DOHomeFeatureItemWDtRng")
                    .HasComment("Feature Item Within Date Range (Home Page)");

                entity.Property(e => e.DohomeNotFeatured)
                    .HasColumnName("DOHomeNotFeatured")
                    .HasComment("Not Featured (Home Page)");

                entity.Property(e => e.DolandingFeatureItem)
                    .HasColumnName("DOLandingFeatureItem")
                    .HasComment("Feature Item (Landing Page)");

                entity.Property(e => e.DolandingFeatureItemWdtRng)
                    .HasColumnName("DOLandingFeatureItemWDtRng")
                    .HasComment("Feature Item Within Date Range (Landing Page)");

                entity.Property(e => e.DolandingNotFeatured)
                    .HasColumnName("DOLandingNotFeatured")
                    .HasComment("Not Featured (Landing Page)");

                entity.Property(e => e.DonewComments)
                    .HasColumnName("DONewComments")
                    .HasComment("Display options if new comments can be made");

                entity.Property(e => e.DoshowComment)
                    .HasColumnName("DOShowComment")
                    .HasComment("Display options if comments are displayed");

                entity.Property(e => e.EnableMl5search)
                    .HasColumnName("EnableML5Search")
                    .HasComment("Enable ML5 Search");

                entity.Property(e => e.PackageTemplate).HasComment("Package Template");

                entity.Property(e => e.PostType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Post Type => 0-Template, 1-Page, 2-Static Document, 3-External URL");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.UnlockedPost).HasComment("UnlockedPost");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");
            });

            modelBuilder.Entity<DisplayOptionCategory>(entity =>
            {
                entity.HasKey(e => e.ContentDisplayOptionCategoryId);

                entity.ToTable("DisplayOptionCategory");

                entity.HasIndex(e => new { e.CategoryId, e.SubCategoryId, e.InteriorCategoryId }, "IX_Categories");

                entity.HasIndex(e => e.ContentDisplayOptionCategoryId, "IX_DisplayOptionCategory");

                entity.Property(e => e.ContentDisplayOptionCategoryId)
                    .HasColumnName("ContentDisplayOptionCategoryID")
                    .HasComment("Id of the table");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("ID of the category table");

                entity.Property(e => e.ContentDisplayOptionId)
                    .HasColumnName("ContentDisplayOptionID")
                    .HasComment("ID of the table Content Display Option");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DisplayStatus).HasComment("Status of the category (display = 0 or hidden = 1)");

                entity.Property(e => e.InteriorCategoryId)
                    .HasColumnName("InteriorCategoryID")
                    .HasComment("ID of the interior category table");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SubCategoryID")
                    .HasComment("ID of the sub category table");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");

                entity.HasOne(d => d.ContentDisplayOption)
                    .WithMany(p => p.DisplayOptionCategories)
                    .HasForeignKey(d => d.ContentDisplayOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DisplayOptionCategory_ContentDisplayOption");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
