using platform_service.Dtos;

namespace platform_service.SyncData
{
    public interface ISendDataToCommand
    {
        Task SendHttpToCommand(PlatformReadDto plat);
    }
}
