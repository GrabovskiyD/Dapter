using Dapter.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dapter.Data;

class DapterDbContext(DbContextOptions<DapterDbContext> options) : DbContext(options)
{
    const string MigrationsHistoryTableName = "__EFMigrationsHistory";

    public DbSet<LifeAspectDb> LifeAspects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=dapter.db", options =>
        {
            options.MigrationsAssembly(typeof(DapterDbContext).Assembly.FullName);
            options.MigrationsHistoryTable(MigrationsHistoryTableName);
        });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DapterDbContext).Assembly);
    }
}
