using AutoMapper;
using Dapter.App.Models;
using Dapter.Core.Models;

namespace Dapter.App;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<LifeAspect, LifeAspectCore>()
            .ReverseMap();
    }
}
