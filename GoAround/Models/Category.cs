using System;
using System.Collections.Generic;
//library for required
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Models
{
    public class Category
    {
        //get/set methods for category id and name
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
