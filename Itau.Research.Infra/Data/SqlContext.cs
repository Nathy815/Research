using Itau.Research.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Research.Infra.Data
{
    public class SqlContext : DbContext
    {
        private IConfiguration _configuration;
        public SqlContext(DbContextOptions<SqlContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        // Common
        public virtual DbSet<Segment> Segment { get; set; }
        public virtual DbSet<Tier> Tier { get; set; }

        // Event
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<EventSegment> EventSegment { get; set; }
        public virtual DbSet<TrackPresence> TrackPresence { get; set; }

        // Profile
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<Score> Score { get; set; }

        // Report
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportSegment> ReportSegment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Event
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Tier)
                .WithMany(t => t.Eventos)
                .HasForeignKey(e => e.TierID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Categoria)
                .WithMany(c => c.Eventos)
                .HasForeignKey(e => e.CategoryID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Score
            modelBuilder.Entity<Score>()
                .HasOne(s => s.Usuario)
                .WithMany(u => u.Scores)
                .HasForeignKey(s => s.UserID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Track
            modelBuilder.Entity<Track>()
                .HasOne(t => t.Evento)
                .WithMany(e => e.Tracks)
                .HasForeignKey(t => t.EventID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Report
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Tier)
                .WithMany(t => t.Reports)
                .HasForeignKey(r => r.TierID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
