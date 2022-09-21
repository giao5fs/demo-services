namespace platform_service.Models
{
    public interface IPlatformRepo
    {
        IEnumerable<Platform> GetAll();
        Platform GetPlatformById(int id);
        Platform CreatePlatform(Platform platform);

    }
}
