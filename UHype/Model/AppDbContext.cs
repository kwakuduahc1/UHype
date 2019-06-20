using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UHype.Model
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Demography> Demography { get; set; }

        public virtual DbSet<Anthropometries> Anthropometries { get; set; }

        public virtual DbSet<BpHistory> BpHistory { get; set; }

        public virtual DbSet<Charts> Charts { get; set; }

        public virtual DbSet<Labs> Labs { get; set; }

        public virtual DbSet<QualityAssessments> QualityAssessments { get; set; }

        public virtual DbSet<SecondSections> SecondSections { get; set; }

        public virtual DbSet<SocioFactors> SocioFactors { get; set; }

        public virtual DbSet<AppUsers> AppUsers { get; set; }
    }
}
