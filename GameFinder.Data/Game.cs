using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public enum GamingConsole { Xbox = 1, PlayStation, Nintendo, Sega}
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public bool FamilyFriendly { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
