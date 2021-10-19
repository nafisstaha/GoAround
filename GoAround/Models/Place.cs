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

        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        public string Photo { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Discription { get; set; }

        public int UserId { get; set; }

        //childs
        public List<Review> Reviews { get; set; }

        //parent category
        public Category Category { get; set; }
    }
}
