using Dapter.Core.Models;

namespace Dapter.Core.Abstractions.Repositories;

public interface ILifeAspectRepository
{
    Task Add(LifeAspect lifeAspect);
    Task<LifeAspect?> Get(Guid id);
    Task<List<LifeAspect>> GetAll();
    Task Update(LifeAspect lifeAspect);
    Task Remove(Guid id);
}
