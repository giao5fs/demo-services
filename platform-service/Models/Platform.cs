using System.ComponentModel.DataAnnotations;

namespace platform_service.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

    }
}
