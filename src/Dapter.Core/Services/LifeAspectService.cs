using Dapter.Core.Abstractions.Repositories;
using Dapter.Core.Abstractions.Services;
using Dapter.Core.Models;

namespace Dapter.Core.Services;

public class LifeAspectService(
    ILifeAspectRepository lifeAspectRepository) : ILifeAspectService
{
    public Task Add(LifeAspect lifeAspect) =>
        lifeAspectRepository.Add(lifeAspect);

    public async Task<Result<LifeAspect>> Get(Guid id) =>
        new Result<LifeAspect>
        {
            Value = await lifeAspectRepository.Get(id)
        };

    public async Task<Result<List<LifeAspect>>> GetAll() =>
        new Result<List<LifeAspect>> 
        { 
            Value = await lifeAspectRepository.GetAll()
        };

    public Task Remove(Guid id) =>
        lifeAspectRepository.Remove(id);

    public Task Update(LifeAspect lifeAspect) =>
        lifeAspectRepository.Update(lifeAspect);
}
