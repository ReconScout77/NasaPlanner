using Microsoft.EntityFrameworkCore;

namespace NasaPlanner.Models
{

    public class NasaPlannerDbContext : DbContext
    {
        public NasaPlannerDbContext()
        {
        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<Crew> Crew { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=NasaPlanner;uid=root;pwd=root;");
        }

        public NasaPlannerDbContext(DbContextOptions<NasaPlannerDbContext> options)
                    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
