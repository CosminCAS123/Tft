using System.ComponentModel.DataAnnotations;

namespace TftWebsite.Models
{
    public class Team
    {
        public ICollection<Champion> Champions { get; set; } = null!;
        [Key]
        public string Name { get; set; } = null!;//find team by this user name.
    }
}
