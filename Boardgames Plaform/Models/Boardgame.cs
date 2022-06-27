using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Boardgames_test.Models
{
    public class Boardgame
    {
        [Key]
        public int BoardgameID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int MinPlayers { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public int Complexity { get; set; }
        [Required]
        public Category Category { get; set; }
        public int Quantity { get; set; }

        public string ImgPath { get; set; }


    }
}
