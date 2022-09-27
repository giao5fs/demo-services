using System.ComponentModel.DataAnnotations;

namespace platform_service.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string PlatformName { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
