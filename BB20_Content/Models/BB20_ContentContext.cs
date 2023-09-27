using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_Content.Models
{
    public partial class BB20_ContentContext : DbContext
    {
        public BB20_ContentContext()
        {
        }

        public BB20_ContentContext(DbContextOptions<BB20_ContentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Contents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.HasIndex(e => e.ContentId, "IX_Content");

                entity.Property(e => e.ContentId)
                    .HasColumnName("ContentID")
                    .HasComment("ID of the content");

                entity.Property(e => e.AlignLeft)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Align Left, if 1 = true, 0 = false then is align right");

                entity.Property(e => e.Ansnotification)
                    .HasColumnName("ANSNotification")
                    .HasComment("App notifications Section => 0-On, 1-Off, 2-High Priority");

                entity.Property(e => e.Author)
                    .HasMaxLength(100)
                    .HasComment("Author of content");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the creation of the row");

                entity.Property(e => e.DeleteFlag).HasComment("If the row is logicaly deleted (0 = false and 1 = true)");

                entity.Property(e => e.DisplayStatus).HasComment("Status of the category (display = 0 or hidden = 1)");

                entity.Property(e => e.DocumentDate).HasComment("DateTime of the creation of the content");

                entity.Property(e => e.Headline)
                    .HasMaxLength(100)
                    .HasComment("Headline of content");

                entity.Property(e => e.Icon).HasComment("Content Icon ");

                entity.Property(e => e.LinkTittle1)
                    .HasMaxLength(75)
                    .HasComment("Link of Content files");

                entity.Property(e => e.LinkTittle2)
                    .HasMaxLength(75)
                    .HasComment("Link of Content files");

                entity.Property(e => e.LinkTittle3)
                    .HasMaxLength(75)
                    .HasComment("Link of Content files");

                entity.Property(e => e.LinkUrl1)
                    .HasMaxLength(500)
                    .HasComment("URL of Content files");

                entity.Property(e => e.LinkUrl2)
                    .HasMaxLength(500)
                    .HasComment("URL of Content files");

                entity.Property(e => e.LinkUrl3)
                    .HasMaxLength(500)
                    .HasComment("URL of Content files");

                entity.Property(e => e.MainText)
                    .HasMaxLength(500)
                    .HasComment("Main text description of content");

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(500)
                    .HasComment("meta text description of content");

                entity.Property(e => e.OpenNewWindows).HasComment("Open in New Windows");

                entity.Property(e => e.PrettyUrl)
                    .HasMaxLength(500)
                    .HasComment("ontent PrettyURL");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("This field is for the management of the concurrency");

                entity.Property(e => e.Share).HasComment("Share");

                entity.Property(e => e.SpanImageAcross).HasComment("Span Image Across");

                entity.Property(e => e.SttbuttonLink)
                    .HasMaxLength(75)
                    .HasColumnName("STTButtonLink")
                    .HasComment("Teaser thumbnail Botton Link");

                entity.Property(e => e.SttbuttonText)
                    .HasMaxLength(75)
                    .HasColumnName("STTButtonText")
                    .HasComment("Teaser thumbnail Botton text");

                entity.Property(e => e.Stticon)
                    .HasColumnName("STTIcon")
                    .HasComment("Teaser thumbnail icon");

                entity.Property(e => e.SttonlyHomePage)
                    .HasColumnName("STTOnlyHomePage")
                    .HasComment("Teaser thumbnail if only use on home page (0=yes and 1=no)");

                entity.Property(e => e.Stttitle)
                    .HasMaxLength(75)
                    .HasColumnName("STTTitle")
                    .HasComment("Teaser thumbnail title");

                entity.Property(e => e.Subtittle)
                    .HasMaxLength(100)
                    .HasComment("Subtittle of content");

                entity.Property(e => e.Teaser)
                    .HasMaxLength(500)
                    .HasComment("Long Teaser of Content");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasComment("Name of Content");

                entity.Property(e => e.UpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("DateTime of the update of the row");

                entity.Property(e => e.WrapTextAroundImages).HasComment("Wrap Text Around Images");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
