using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CTSOrderMgr.Models
{
    public partial class CTSOrderMgrContext : DbContext
    {
        public virtual DbSet<FileTracker> FileTracker { get; set; }
        public virtual DbSet<FileTrackerStatus> FileTrackerStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=192.168.5.122;Database=CTSOrderMgr;User Id=larry;Password=share_99;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileTracker>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDatetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Hide).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDatetime).HasColumnType("datetime");

                entity.HasOne(d => d.FileTrackerStatus)
                    .WithMany(p => p.FileTracker)
                    .HasForeignKey(d => d.FileTrackerStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__20161031lch_FileTracker__20161031lch_FileTrackerStatus");
            });

            modelBuilder.Entity<FileTrackerStatus>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}