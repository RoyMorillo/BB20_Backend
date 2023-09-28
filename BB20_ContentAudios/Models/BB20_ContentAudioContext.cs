using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BB20_ContentAudios.Models
{
    public partial class BB20_ContentAudioContext : DbContext
    {
        public BB20_ContentAudioContext()
        {
        }

        public BB20_ContentAudioContext(DbContextOptions<BB20_ContentAudioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContentAudio> ContentAudios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentAudio>(entity =>
            {
                entity.ToTable("ContentAudio");

                entity.HasIndex(e => e.ContentAudioId, "IX_ContentAudio");

                entity.HasIndex(e => e.ContentId, "IX_ContentID");

                entity.Property(e => e.ContentAudioId)
                    .HasColumnName("ContentAudioID")
                    .HasComment("Id of the table");

                entity.Property(e => e.Audioanimation)
                    .HasColumnName("AUDIOAnimation")
                    .HasComment("if the audio must have animation");

                entity.Property(e => e.Audioartist)
                    .HasMaxLength(75)
                    .HasColumnName("AUDIOArtist")
                    .HasComment("Audio Artist");

                entity.Property(e => e.AudioautoStart)
                    .HasColumnName("AUDIOAutoStart")
                    .HasComment("if the audio should auto-start");

                entity.Property(e => e.Audiofile)
                    .HasColumnName("AUDIOFile")
                    .HasComment("Audio File");

                entity.Property(e => e.AudiohideInfo)
                    .HasColumnName("AUDIOHideInfo")
                    .HasComment("if the audio should be hidden");

                entity.Property(e => e.Audioloop)
                    .HasColumnName("AUDIOLoop")
                    .HasComment("if the audio should be repeated");

                entity.Property(e => e.Audiovalume)
                    .HasColumnName("AUDIOValume")
                    .HasComment("initial audio volume");

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
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
