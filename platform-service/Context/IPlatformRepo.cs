using platform_service.Models;

namespace platform_service.Context
{
    public interface IPlatformRepo
    {
        IEnumerable<Platform> GetAll();
        Platform GetPlatformById(int id);
        Platform CreatePlatform(Platform platform);

    }
}
