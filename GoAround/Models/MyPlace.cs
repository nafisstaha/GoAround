using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Models
{
    public class MyPlace
    {
        public int MyPlaceId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string Photo { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public string Address { get; set; }

        public string Discription { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public User User { get; set; }

        public List<Review> Reviews { get; set; }

        public Category Category { get; set; }
    }
}