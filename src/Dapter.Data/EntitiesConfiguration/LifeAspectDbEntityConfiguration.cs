using Dapter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dapter.Data.EntitiesConfiguration;

class LifeAspectDbEntityConfiguration : IEntityTypeConfiguration<LifeAspectDb>
{
    public void Configure(EntityTypeBuilder<LifeAspectDb> builder)
    {
        builder
            .HasKey(la => la.Id);

        builder
            .Property(la => la.Name)
            .IsRequired();

        builder
            .Property(la => la.Description);
    }
}
