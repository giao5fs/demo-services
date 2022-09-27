using System.ComponentModel.DataAnnotations;

namespace platform_service.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PlatformName { get; set; }
        [Required]
        public string Cost { get; set; }

    }
}
