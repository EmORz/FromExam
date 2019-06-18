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
            optionsBuilder.UseSqlServer(DbSettings.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasMany(x => x.Packages)
            //    .WithOne(x => x.Recipient).HasForeignKey(x => x.RecipientId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>().HasMany(x => x.Receipts)
            //    .WithOne(x => x.Recipient).HasForeignKey(x => x.RecipientId)
            //    .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}