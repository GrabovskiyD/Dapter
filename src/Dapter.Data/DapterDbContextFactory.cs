using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Dapter.Data;

class DapterDbContextFactory : IDesignTimeDbContextFactory<DapterDbContext>
{
    public DapterDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DapterDbContext>();
        optionsBuilder.UseSqlite("Filename=dapter.db");

        return new DapterDbContext(optionsBuilder.Options);
    }
}
