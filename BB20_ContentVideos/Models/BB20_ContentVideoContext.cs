using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_ContentVideos.Models
{
    public partial class BB20_ContentVideoContext : DbContext
    {
        public BB20_ContentVideoContext()
        {
        }

        public BB20_ContentVideoContext(DbContextOptions<BB20_ContentVideoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContentVideo> ContentVideos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentVideo>(entity =>
            {
                entity.ToTable("ContentVideo");

                entity.HasIndex(e => e.ContentId, "IX_ContentID");

                entity.HasIndex(e => e.ContentVideoId, "IX_ContentVideo");

                entity.Property(e => e.ContentVideoId)
                    .HasColumnName("ContentVideoID")
                    .HasComment("ID of the table");

                entity.Property(e => e.ContentId)
                    .HasColumnName("ContentID")
                    .HasComment("ID of the content table");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");

                entity.Property(e => e.Videoautostart)
                    .HasColumnName("VIDEOAutostart")
                    .HasComment("If the video should self-start");

                entity.Property(e => e.Videocaption)
                    .HasMaxLength(500)
                    .HasColumnName("VIDEOCaption")
                    .HasComment("Video caption");

                entity.Property(e => e.Videofiles)
                    .HasColumnName("VIDEOFiles")
                    .HasComment("Video file");

                entity.Property(e => e.Videoheight)
                    .HasColumnName("VIDEOHeight")
                    .HasComment("Video height");

                entity.Property(e => e.Videoicon)
                    .HasColumnName("VIDEOIcon")
                    .HasComment("Video image");

                entity.Property(e => e.Videoloop)
                    .HasColumnName("VIDEOLoop")
                    .HasComment("If the video should be repeated");

                entity.Property(e => e.Videowidth)
                    .HasColumnName("VIDEOWidth")
                    .HasComment("Video Width");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
