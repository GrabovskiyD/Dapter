using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dapter.App.Models;
using Dapter.Core.Abstractions.Services;
using Dapter.Core.Models;
using System.Collections.ObjectModel;

namespace Dapter.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly ILifeAspectService _lifeAspectService;
    private readonly IMapper _mapper;

    public ObservableCollection<LifeAspect> LifeAspects { get; } = [new LifeAspect
    {
        Id = Guid.NewGuid(),
        Name = "Name",
        Description = "Description"
    }];

    public MainPageViewModel(
        ILifeAspectService lifeAspectService,
        IMapper mapper)
    {
        _lifeAspectService = lifeAspectService;
        _mapper = mapper;

        GetAllCommand.Execute(this);
    }

    [RelayCommand]
    private async Task Add(LifeAspect lifeAspect)
    {
        var lifeAspectCore = _mapper.Map<LifeAspectCore>(lifeAspect);

        await _lifeAspectService.Add(lifeAspectCore);
    }

    [RelayCommand]
    private async Task GetAll()
    {
        var lifeAspectsCore = await _lifeAspectService.GetAll();

        if (lifeAspectsCore.Value is not { Count: > 0 }) return;

        foreach (var lifeAspectCore in lifeAspectsCore.Value)
        {
            var lifeAspect = _mapper.Map<LifeAspect>(lifeAspectCore);

            LifeAspects.Add(lifeAspect);
        }
    }
}
