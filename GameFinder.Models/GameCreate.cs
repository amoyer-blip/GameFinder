using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GameCreate
    {
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
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
