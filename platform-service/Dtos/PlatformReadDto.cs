using System.ComponentModel.DataAnnotations;

namespace platform_service.Dtos
{
    public class PlatformReadDto
    {
        public int Id { get; set; }
        public string PlatformName { get; set; }
        public string Cost { get; set; }
    }
}
