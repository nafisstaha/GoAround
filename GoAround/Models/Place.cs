using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Models
{
    public class Place
    {
        public int PlaceId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Photo { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public string Address { get; set; }

        public string Discription { get; set; }

        [Required]
        public int UserId { get; set; }

        //childs
        public List<Review> Reviews { get; set; }

        //parent category
        public Category Category { get; set; }
    }
}
