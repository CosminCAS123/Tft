using System.ComponentModel.DataAnnotations;

namespace TftWebsite.Models
{
    public class Trait
    {
        [Key]
        public ETrait Name { get; set; }

        public string Description { get; set; } = null!;

    }
}
