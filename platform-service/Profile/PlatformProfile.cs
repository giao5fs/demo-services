using AutoMapper;
using AutoMapper.Internal;
using Microsoft.Extensions.DependencyInjection;
using platform_service.Dtos;
using platform_service.Models;

namespace platform_service.Profile
{
    public class PlatformProfile
    {
        public PlatformProfile()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Platform, PlatformReadDto>();
                cfg.CreateMap<PlatformCreateDto, Platform>();
            });
            // only during development, validate your mappings; remove it before release
            configuration.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            var mapper = configuration.CreateMapper();
        }

    }
}
