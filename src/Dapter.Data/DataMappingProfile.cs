using AutoMapper;
using Dapter.Core.Models;
using Dapter.Data.Entities;

namespace Dapter.Data;

internal class DataMappingProfile : Profile
{
    public DataMappingProfile()
    {
        CreateMap<LifeAspectCore, LifeAspectDb>()
            .ReverseMap();
    }
}
