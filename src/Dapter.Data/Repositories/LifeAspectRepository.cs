using AutoMapper;
using Dapter.Core.Abstractions.Repositories;
using Dapter.Core.Models;
using Dapter.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dapter.Data.Repositories;

public class LifeAspectRepository(
    DapterDbContext dbContext,
    IMapper mapper) : ILifeAspectRepository
{
    public Task Add(LifeAspect lifeAspect)
    {
        var lifeAspectDb = mapper.Map<LifeAspectDb>(lifeAspect);

        dbContext.LifeAspects.Add(lifeAspectDb);
        return dbContext.SaveChangesAsync();
    }

    public async Task<LifeAspect?> Get(Guid id)
    {
        var lifeAspectDb = await dbContext
            .LifeAspects
            .FirstOrDefaultAsync(la => la.Id == id);

        return mapper.Map<LifeAspect?>(lifeAspectDb);
    }

    public async Task<List<LifeAspect>> GetAll()
    {
        return mapper.Map<List<LifeAspect>>(
            await dbContext.LifeAspects.ToListAsync());
    }

    public async Task Remove(Guid id)
    {
        var lifeAspectDb = await dbContext.LifeAspects.FindAsync(id);

        if(lifeAspectDb != null)
        {
            dbContext.LifeAspects.Remove(lifeAspectDb);
            await dbContext.SaveChangesAsync();
        }
    }

    public Task Update(LifeAspect lifeAspect)
    {
        var lifeAspectDb = mapper.Map<LifeAspectDb>(lifeAspect);

        dbContext.LifeAspects.Update(lifeAspectDb);
        return dbContext.SaveChangesAsync();
    }
}
