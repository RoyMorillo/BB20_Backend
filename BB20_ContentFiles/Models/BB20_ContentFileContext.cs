using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_ContentFiles.Models
{
    public partial class BB20_ContentFileContext : DbContext
    {
        public BB20_ContentFileContext()
        {
        }

        public BB20_ContentFileContext(DbContextOptions<BB20_ContentFileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContentFile> ContentFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentFile>(entity =>
            {
                entity.ToTable("ContentFile");

                entity.HasIndex(e => e.ContentFileId, "IX_ContentFile");

                entity.HasIndex(e => e.ContentId, "IX_ContentID");

                entity.Property(e => e.ContentFileId)
                    .HasColumnName("ContentFileID")
                    .HasComment("ID of the table");

                entity.Property(e => e.AssociatedFileTitle)
                    .HasMaxLength(75)
                    .HasComment("Title of Content files");

                entity.Property(e => e.AssociatedFiles).HasComment("es tipo archivo .zip, pdf, doc");

                entity.Property(e => e.ContentId)
                    .HasColumnName("ContentID")
                    .HasComment("ID of the content Table");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.ShowTerms).HasComment("if the terms are displayed");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
