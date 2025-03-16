using Dapter.Core.Models;

namespace Dapter.Core.Abstractions.Services;

public interface ILifeAspectService
{
    Task Add(LifeAspectCore lifeAspect);
    Task<Result<LifeAspectCore>> Get(Guid id);
    Task<Result<List<LifeAspectCore>>> GetAll();
    Task Update(LifeAspectCore lifeAspect);
    Task Remove(Guid id);
}
