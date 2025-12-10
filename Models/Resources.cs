using System.ComponentModel.DataAnnotations;

namespace MinecraftAPI.Models
{
    public class Resources
    {
        [Key]
        public int? ResourceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? ResourceName { get; set; }

        [MaxLength(50)]
        public string? Rarity { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}