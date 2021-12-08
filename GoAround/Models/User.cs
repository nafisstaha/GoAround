using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [Range(1, 9999)]
        public int Age { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<MyPlace> MyPlaces { get; set; }

        public List<Place> Places { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
