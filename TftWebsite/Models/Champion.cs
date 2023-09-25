using System.ComponentModel.DataAnnotations;

namespace TftWebsite.Models
{
    public class Champion
    {
        [Key]
        public string Name { get; set; } = null!;
        public ICollection<Trait> Traits { get; set; } = null!;


    }
}
