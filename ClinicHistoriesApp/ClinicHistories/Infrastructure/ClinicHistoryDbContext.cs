using ClinicHistories.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicHistories.Infrastructure
{
    public class ClinicHistoryDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }

        public ClinicHistoryDbContext(DbContextOptions<ClinicHistoryDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Patient>();
            builder.Entity<Location>();
            builder.Entity<HealthCare>();
            builder.Entity<Phone>();
        }
    }
}
