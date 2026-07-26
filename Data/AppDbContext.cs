using Microsoft.EntityFrameworkCore;
using VRTraining.Models;

namespace VRTraining.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // quiz_results table
        public DbSet<QuizResult> quiz_results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuizResult>()
                .ToTable("quiz_results");

            modelBuilder.Entity<QuizResult>()
                .HasKey(q => q.Id);
        }
    }
}