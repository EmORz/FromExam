using SULS.Models;

namespace SULS.Data
{
    using Microsoft.EntityFrameworkCore;

    public class SULSContext : DbContext
    {
        // TODO
        public DbSet<User> Users { get; set; }

        public DbSet<Problem> Problems { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConfiguration.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(user => user.Id);

            modelBuilder.Entity<Problem>()
                .HasKey(problem => problem.Id);

            modelBuilder.Entity<Submission>()
                .HasKey(submissions => submissions.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}