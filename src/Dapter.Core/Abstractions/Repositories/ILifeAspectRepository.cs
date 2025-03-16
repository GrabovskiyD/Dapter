using Dapter.Core.Models;

namespace Dapter.Core.Abstractions.Repositories;

public interface ILifeAspectRepository
{
    Task Add(LifeAspectCore lifeAspect);
    Task<LifeAspectCore?> Get(Guid id);
    Task<List<LifeAspectCore>> GetAll();
    Task Update(LifeAspectCore lifeAspect);
    Task Remove(Guid id);
}
