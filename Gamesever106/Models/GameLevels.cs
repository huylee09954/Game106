using System.ComponentModel.DataAnnotations;

namespace Gamesever106.Models
{
    public class GameLevels
    {
        [Key]
        public int LevelId { get; set; }
        public string title { get; set; }
        public string? Description { get; set; }
    }
}
