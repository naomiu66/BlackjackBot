using BlackjackBot.Data.Configurations;
using BlackjackBot.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackjackBot.Data
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<User> Users;
        public DbSet<Session> Sessions;
        public DbSet<Hand> Hands;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new SessionsConfiguration());
            modelBuilder.ApplyConfiguration(new HandsConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
