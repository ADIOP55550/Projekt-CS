using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Kalendarz.Db
{
    public partial class CalendarContext : DbContext
    {
        public CalendarContext()
        {
        }

        public CalendarContext(DbContextOptions<CalendarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=calendarcontext;user=root;port=3306",
                    ServerVersion.Parse("10.4.14-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.ToTable("entry");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("content")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.IsStarred).HasColumnName("is_starred");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.HasIndex(e => e.EntryId, "tag_entry_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("color")
                    .HasDefaultValue("FFFFFFFF")
                    .IsFixedLength(true);

                entity.Property(e => e.EntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_id");

                entity.Property(e => e.Highlight).HasColumnName("highlight");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("Priority");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("tag_entry_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}