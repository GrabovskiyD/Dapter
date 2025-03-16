using Dapter.Core.Models;

namespace Dapter.Core.Abstractions.Services;

public interface ILifeAspectService
{
    Task Add(LifeAspect lifeAspect);
    Task<Result<LifeAspect>> Get(Guid id);
    Task<Result<List<LifeAspect>>> GetAll();
    Task Update(LifeAspect lifeAspect);
    Task Remove(Guid id);
}
