using Microsoft.EntityFrameworkCore;

namespace asibproject.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=postgres57.1gb.ru;Port=5432;Database=xgb_tumen;User ID=xgb_tumen;Password=X-gL2a3H-wpY;Pooling=true;");
        }

    }
}
