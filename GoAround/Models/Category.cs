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

        //suitable range and name for CategoryId
        [Range(1, 9999)]
        [Display(Name = "Id")]
        public int CategoryId { get; set; }

        //Required name with a new error message
        [Required(ErrorMessage = "We'll happy, if know the name of your place :)")]
        public string Name { get; set; }
    }
}
