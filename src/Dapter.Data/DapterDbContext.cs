using Dapter.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dapter.Data;

public class DapterDbContext(DbContextOptions<DapterDbContext> options) : DbContext(options)
{
    const string SchemaName = "dapter";
    internal const string MigrationsHistoryTableName = "__EFMigrationsHistory";

    public DbSet<LifeAspectDb> LifeAspects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(SchemaName);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DapterDbContext).Assembly);
    }
}
