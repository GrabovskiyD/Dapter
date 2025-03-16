using Dapter.Core.Abstractions.Repositories;
using Dapter.Core.Abstractions.Services;
using Dapter.Core.Models;

namespace Dapter.Core.Services;

public class LifeAspectService(
    ILifeAspectRepository lifeAspectRepository) : ILifeAspectService
{
    public Task Add(LifeAspectCore lifeAspect) =>
        lifeAspectRepository.Add(lifeAspect);

    public async Task<Result<LifeAspectCore>> Get(Guid id) =>
        new Result<LifeAspectCore>
        {
            Value = await lifeAspectRepository.Get(id)
        };

    public async Task<Result<List<LifeAspectCore>>> GetAll() =>
        new Result<List<LifeAspectCore>> 
        { 
            Value = await lifeAspectRepository.GetAll()
        };

    public Task Remove(Guid id) =>
        lifeAspectRepository.Remove(id);

    public Task Update(LifeAspectCore lifeAspect) =>
        lifeAspectRepository.Update(lifeAspect);
}
