using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Models
{
    public class Review
    {
        [Required]
        public int ReviewId { get; set; }

        public string Comment { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Range(1, 5)]
        public decimal Rate { get; set; }

        public Place Place { get; set; }

        public MyPlace MyPlace { get; set; }

        public User User { get; set; }



    }
}
